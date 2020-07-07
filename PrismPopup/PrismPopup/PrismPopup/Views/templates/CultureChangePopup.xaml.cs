using PrismPopup.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrismPopup.Views.templates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CultureChangePopup : ContentView
    {
        public void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //await Task.Delay(400);
            //if (Application.Current.MainPage.Navigation.NavigationStack.Last() is MainPage)
            //{
            //    popup.Show();
            //}
            popup.Show();            
        }

        public void NavigateMenuButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        public CultureChangePopup()
        {
            InitializeComponent();
            Device.BeginInvokeOnMainThread(async () => { SetRTL(CultureInfo.CurrentCulture.ToString()); });
        }

        private void SetRTL(string lang)
        {
            if (lang == CultureService.RTLLanguage)
            {
                popup.FlowDirection = FlowDirection.RightToLeft;
            }
            else
            {
                popup.FlowDirection = FlowDirection.LeftToRight;
            }
        }
    }
}