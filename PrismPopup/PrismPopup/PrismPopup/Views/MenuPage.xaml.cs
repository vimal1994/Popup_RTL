using PrismPopup.Helpers;
using System.Globalization;
using Xamarin.Forms;

namespace PrismPopup.Views
{
    public partial class MenuPage : ContentPage
    {
        private const string LTRLanguage = "en-US";
        private const string RTLLanguage = "ar";

        public MainPage Main
        {
            get;
            set;
        }
        public MenuPage(MainPage mainPage)
        {
            InitializeComponent();
            this.Main = mainPage;
        }

        private void LTRButton_Clicked(object sender, System.EventArgs e)
        {
            CultureService.SetCultureForLanguage(LTRLanguage);

        }

        private void RTLButton_Clicked(object sender, System.EventArgs e)
        {
            CultureService.SetCultureForLanguage(RTLLanguage);
        }

        private async void NavigateToMainPageButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
