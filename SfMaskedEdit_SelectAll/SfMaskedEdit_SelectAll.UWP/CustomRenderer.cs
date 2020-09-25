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

[assembly: ExportRenderer(typeof(SfMaskedEditExt), typeof(CustomRenderer))]
namespace SfMaskedEdit_SelectAll.UWP
{
    public class CustomRenderer : SfMaskedEditRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Syncfusion.XForms.MaskedEdit.SfMaskedEdit> e)
        {
            base.OnElementChanged(e);
            SfMaskedEditExt sfMaskedEditExt = e.NewElement as SfMaskedEditExt;
            sfMaskedEditExt.Focused += SfMaskedEditExt_Focused;
          
        }

        private void SfMaskedEditExt_Focused(object sender, Xamarin.Forms.FocusEventArgs e)
        {
            if (Control != null)
            {
                Control.SelectAll();
            }
        }
    }
}
