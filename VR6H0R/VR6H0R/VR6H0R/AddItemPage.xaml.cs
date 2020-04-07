using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VR6H0R.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VR6H0R
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddItemPage : ContentPage
	{
		public AddItemPage ()
		{
			InitializeComponent ();
            this.BindingContext = new AddItemViewModel(Navigation);
        }
	}
}