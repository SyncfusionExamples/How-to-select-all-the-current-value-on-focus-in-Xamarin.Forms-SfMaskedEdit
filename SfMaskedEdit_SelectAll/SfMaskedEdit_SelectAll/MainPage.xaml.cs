using Syncfusion.XForms.MaskedEdit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SfMaskedEdit_SelectAll
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class SfMaskedEditExt : SfMaskedEdit
    {
        public bool SelectOnFocus { get; set; }
    }
}
