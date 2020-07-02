using Xamarin.Forms;

namespace PrismPopup.Views
{
    public partial class BusyIndicatorControl
    {
        public BusyIndicatorControl()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            this.Show();
        }
    }
}
