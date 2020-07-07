using PrismPopup.Helpers;
using System;
using System.Globalization;
using Xamarin.Forms;

namespace PrismPopup.Views
{
    public partial class PopupDetailsInfoPage : ContentPage
    {
        public PopupDetailsInfoPage()
        {
            InitializeComponent();
            Device.BeginInvokeOnMainThread(async () => { SetRTL(CultureInfo.CurrentCulture.ToString()); });
        }

        private void SetRTL(string lang)
        {
            if (lang.Equals(CultureService.RTLLanguage))
            {
                CountryGrid.FlowDirection = FlowDirection.RightToLeft;
            }
            else
            {
                CountryGrid.FlowDirection = FlowDirection.LeftToRight;
            }
        }
    }
}
