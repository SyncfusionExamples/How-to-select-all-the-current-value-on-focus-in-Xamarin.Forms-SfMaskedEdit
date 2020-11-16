using Syncfusion.XForms.MaskedEdit;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SfMaskedEdit_SelectAll
{
    public class ExtMaskedEdit : SfMaskedEdit
    {
        public bool SelectAllOnFocus
        {
            get { return (bool)GetValue(SelectAllOnFocusProperty); }
            set { SetValue(SelectAllOnFocusProperty, value); }
        }
        public static readonly BindableProperty SelectAllOnFocusProperty =
            BindableProperty.Create("SelectAllOnFocus", typeof(bool), typeof(ExtMaskedEdit), false);
    }
}
