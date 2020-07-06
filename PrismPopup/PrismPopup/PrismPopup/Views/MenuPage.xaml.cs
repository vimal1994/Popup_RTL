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

        //private async void Button_Clicked(object sender, System.EventArgs e)
        //{
            
        //}

        //private void Button_Clicked_1(object sender, System.EventArgs e)
        //{

        //}

        //private void Button_Clicked_2(object sender, System.EventArgs e)
        //{

        //}

        private void LTRButton_Clicked(object sender, System.EventArgs e)
        {
            CultureService.SetCultureForLanguage(LTRLanguage);
            //DependencyService.Get<ILocalize>().SetLocale(new CultureInfo("en-US"));
            //Main.SetRTL("en-US");
        }

        private void RTLButton_Clicked(object sender, System.EventArgs e)
        {
            CultureService.SetCultureForLanguage(RTLLanguage);
            //DependencyService.Get<ILocalize>().SetLocale(new CultureInfo("ar"));
            //Main.SetRTL("ar");
        }

        private async void NavigateToMainPageButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
