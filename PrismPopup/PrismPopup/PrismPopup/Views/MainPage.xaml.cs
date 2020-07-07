using Prism.Navigation;
using PrismPopup.Helpers;
using PrismPopup.ViewModels;
using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrismPopup.Views
{
    public partial class MainPage : ContentPage
    {
        private const string  RTLLanguage = "ar";

        public MainPage()
        {
            InitializeComponent();
            this.SetRTL(CultureInfo.CurrentCulture.ToString());
        }
        public void SetRTL(string lang)
        {
            if (CultureService.GetCultureForLanguage().Equals(RTLLanguage)) {
                Device.BeginInvokeOnMainThread(() => { popup.FlowDirection = FlowDirection.RightToLeft; });
            }
            else {
                Device.BeginInvokeOnMainThread(() => { popup.FlowDirection = FlowDirection.LeftToRight; });
            }
        }

    }
}