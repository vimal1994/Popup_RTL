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
            if (CultureService.GetCultureForLanguage().Equals(RTLLanguage))
            //if (lang == "ar")
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    //this.FlowDirection = FlowDirection.RightToLeft;
                    popup.FlowDirection = FlowDirection.RightToLeft;
                });
            }
            else
            {
                Device.BeginInvokeOnMainThread(() => 
                {
                  //  this.FlowDirection = FlowDirection.LeftToRight;
                    popup.FlowDirection = FlowDirection.LeftToRight;
                });
            }
        }
        //private async void Button_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new SecondPage(this));
        //}

        //void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        //{
        //    this.popup.Show();
        //}
        //private void Button_Clicked_1(object sender, EventArgs e)
        //{
        //    this.popup.Show();
        //}

        //private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        //{
        //    this.popup.Show();
        //}
    }
}