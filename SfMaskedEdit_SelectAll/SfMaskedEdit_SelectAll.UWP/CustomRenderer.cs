using SfMaskedEdit_SelectAll;
using SfMaskedEdit_SelectAll.UWP;
using Syncfusion.XForms.MaskedEdit;
using Syncfusion.XForms.UWP.MaskedEdit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(ExtMaskedEdit), typeof(CustomRenderer))]
namespace SfMaskedEdit_SelectAll.UWP
{
    public class CustomRenderer : SfMaskedEditRenderer
    {
        ExtMaskedEdit sfMaskedEditExt;
        protected override void OnElementChanged(ElementChangedEventArgs<Syncfusion.XForms.MaskedEdit.SfMaskedEdit> e)
        {
            base.OnElementChanged(e);
            sfMaskedEditExt = e.NewElement as ExtMaskedEdit;
            sfMaskedEditExt.Focused += SfMaskedEditExt_Focused;
          
        }

        private void SfMaskedEditExt_Focused(object sender, Xamarin.Forms.FocusEventArgs e)
        {
            if (Control != null && sfMaskedEditExt.SelectAllOnFocus)
            {
                Control.SelectAll();
            }
        }
    }
}
