using System.Globalization;
using Xamarin.Forms;

namespace PrismPopup.Views
{
    public partial class SecondPage : ContentPage
    {
        public MainPage Main
        {
            get;
            set;
        }
        public SecondPage(MainPage mainPage)
        {
            InitializeComponent();
            this.Main = mainPage;
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private void Button_Clicked_1(object sender, System.EventArgs e)
        {
            DependencyService.Get<ILocalize>().SetLocale(new CultureInfo("en-US"));
            Main.SetRTL("en-US");
        }

        private void Button_Clicked_2(object sender, System.EventArgs e)
        {
            DependencyService.Get<ILocalize>().SetLocale(new CultureInfo("ar"));
            Main.SetRTL("ar");
        }
    }
}
