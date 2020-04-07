using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using VR6H0R.Services;
using Xamarin.Forms;

namespace VR6H0R.ViewModels
{
    public class AddItemViewModel : ViewModelBase
    {
        private string title; public string Title
        {
            get { return title; }
            set { title = value; OnPropertyChanged();}
        }
        private string description;
        public string Description {
            get { return description; }
            set { description = value; OnPropertyChanged();}
        }
        private bool isFinished;
        public bool IsFinished
        {
            get { return isFinished; }
            set { isFinished = value; OnPropertyChanged(); }
        }

        public ICommand SaveItemCommand { get; }

        public AddItemViewModel(INavigation navigation) : base(navigation)
        {
            SaveItemCommand = new Command(AddItemCommandExecute);
        }
        private async void AddItemCommandExecute()
        {
            TodoService.Instance.AddItem(Title, Description, IsFinished);
            await Navigation.PopAsync(true);
        }
    }
}
