using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VR6H0R.ViewModels;
using Xamarin.Forms;

namespace VR6H0R
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainViewModel(Navigation);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing(); (this.BindingContext as MainViewModel).OnAppearing();
        }
    }
}
