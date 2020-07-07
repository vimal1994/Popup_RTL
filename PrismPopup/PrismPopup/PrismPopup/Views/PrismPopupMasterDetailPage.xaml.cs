using PrismPopup.Helpers;
using Xamarin.Forms;

namespace PrismPopup.Views
{
    public partial class PrismPopupMasterDetailPage : MasterDetailPage
    {
        private const string LTRLanguage = "en-US";
        private const string RTLLanguage = "ar";

        public PrismPopupMasterDetailPage()
        {
            InitializeComponent();
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