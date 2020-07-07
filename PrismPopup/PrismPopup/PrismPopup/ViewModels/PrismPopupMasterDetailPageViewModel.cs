using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Xamarin.Forms;

namespace PrismPopup.ViewModels
{
    public class PrismPopupMasterDetailPageViewModel : BindableBase
    {
        public PrismPopupMasterDetailPageViewModel(INavigationService navigationService)
        {
			_navigationService = navigationService;
			NavigateToLTR_RTLPageCommand = new DelegateCommand<string>(GoToDetailPage, CanGoToDetailPage);
		}

		#region Properties

		public INavigationService _navigationService { get; set; }

		#endregion

		#region DelegateComands

		#region NavigateToLTR_RTLPageCommand
		public DelegateCommand<string> NavigateToLTR_RTLPageCommand { get; private set; }

		async void GoToDetailPage(string detailPageName)
		{
			//implement logic
			try
			{
				await _navigationService.NavigateAsync($"/PrismPopupMasterDetailPage/NavigationPage/{detailPageName}");
			}
			catch (Exception ex)
			{
#if DEBUG
				Debug.WriteLine("Error occurred during navigation " + ex.Message);
#endif
				throw;
			}
		}

		bool CanGoToDetailPage(string detailPageName)
		{
			return true;
		}

		#endregion



		#endregion
	}
}
