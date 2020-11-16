using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SfMaskedEdit_SelectAll;
using SfMaskedEdit_SelectAll.Droid;
using Syncfusion.XForms.Android.MaskedEdit;
using Syncfusion.XForms.MaskedEdit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ExtMaskedEdit),typeof(CustomRenderer))]
namespace SfMaskedEdit_SelectAll.Droid
{
    public class CustomRenderer : SfMaskedEditRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<SfMaskedEdit> e)
        {
            base.OnElementChanged(e);
            if(Control != null)
            {
                Control.SetSelectAllOnFocus((Element as ExtMaskedEdit).SelectAllOnFocus);
            }
        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if(e.PropertyName.Equals("SelectAllOnFocus"))
            {
                Control.SetSelectAllOnFocus((Element as ExtMaskedEdit).SelectAllOnFocus);
            }
        }
    }
}