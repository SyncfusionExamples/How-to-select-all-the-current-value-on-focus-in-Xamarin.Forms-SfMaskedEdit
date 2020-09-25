using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SfMaskedEdit_SelectAll;
using SfMaskedEdit_SelectAll.iOS;
using Syncfusion.XForms.iOS.MaskedEdit;
using Syncfusion.XForms.MaskedEdit;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(SfMaskedEditExt), typeof(CustomRenderer))]
namespace SfMaskedEdit_SelectAll.iOS
{
    public class CustomRenderer : SfMaskedEditRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<SfMaskedEdit> e)
        {
            base.OnElementChanged(e);
            if(Control != null)
            {
                Control.EditingDidBegin += Control_EditingDidBegin;
            }
        }

        private void Control_EditingDidBegin(object sender, EventArgs e)
        {
            Control.PerformSelector(new ObjCRuntime.Selector("selectAll"), null, 0.0f);
        }
    }
}