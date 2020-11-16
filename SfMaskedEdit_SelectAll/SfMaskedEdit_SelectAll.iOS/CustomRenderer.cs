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

[assembly: ExportRenderer(typeof(ExtMaskedEdit), typeof(CustomRenderer))]
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
            if((Element as ExtMaskedEdit).SelectAllOnFocus)
            Control.PerformSelector(new ObjCRuntime.Selector("selectAll"), null, 0.0f);
        }
    }
}