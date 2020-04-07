using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using VR6H0R.Models;
using VR6H0R.Services;
using Xamarin.Forms;

namespace VR6H0R.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        public List<TodoItem> Items => TodoService.Instance.GetAll();

        public ICommand AddItemCommand { get; }

        public MainViewModel(INavigation navigation): base(navigation)
        {
            AddItemCommand = new Command(AddItemCommandExecute);
        }

        private async void AddItemCommandExecute()
        {
           await Navigation.PushAsync(new AddItemPage(), true);
        }

        public override void OnAppearing()
        {
            base.OnAppearing();
            OnPropertyChanged(nameof(Items));
        }

    }
}
