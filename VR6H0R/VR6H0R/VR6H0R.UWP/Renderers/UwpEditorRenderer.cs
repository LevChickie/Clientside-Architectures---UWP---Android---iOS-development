using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VR6H0R.UWP.Renderers;
using VR6H0R.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(CustomEditor),typeof(UwpEditorRenderer))]
namespace VR6H0R.UWP.Renderers
{
   
    public class UwpEditorRenderer:EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);
            if(Control!= null)
            {
                Control.BorderThickness = new Windows.UI.Xaml.Thickness(1);
            }
        }
    }
}
