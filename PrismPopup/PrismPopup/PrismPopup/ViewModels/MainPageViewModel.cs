using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Syncfusion.XForms.PopupLayout;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PrismPopup.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private bool displayPopup;
        public DelegateCommand<SfPopupLayout> OpenPopupCommand { get; set; }
        public DelegateCommand<SfPopupLayout>Change { get; set; }
        public DelegateCommand<SfPopupLayout>ExChange { get; set; }
        public bool DisplayPopup
        {
            get
            {
                return displayPopup;
            }
            set
            {
                displayPopup = value;
                RaisePropertyChanged("DisplayPopup");
            }
        }
        public ObservableCollection<VeggieViewModel> veggies { get; set; }
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }

        
        private void ChangeRTL(SfPopupLayout popupLayout)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                var cultureInfo = CultureInfo.GetCultureInfo("ar-SA");
                Thread.CurrentThread.CurrentCulture = cultureInfo;
                Thread.CurrentThread.CurrentUICulture = cultureInfo;
                CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
                CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
                popupLayout.FlowDirection = FlowDirection.RightToLeft;
                popupLayout.FlowDirection = FlowDirection.RightToLeft;
            });
        }
        private void ChangeLTR(SfPopupLayout popupLayout)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                var cultureInfo = CultureInfo.GetCultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = cultureInfo;
                Thread.CurrentThread.CurrentUICulture = cultureInfo;
                CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
                CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
               
                popupLayout.FlowDirection = FlowDirection.LeftToRight;
                popupLayout.FlowDirection = FlowDirection.LeftToRight;
            });
        }
        private async void OpenPopup(SfPopupLayout popupLayout)
        {
            popupLayout.Show();
        }
    }

    public class VeggieViewModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
    }
}
