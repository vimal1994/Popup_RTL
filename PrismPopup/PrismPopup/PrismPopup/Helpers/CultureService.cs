using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace PrismPopup.Helpers
{
    public static class CultureService
    {
        internal const string LTRLanguage = "en-US";
        internal const string RTLLanguage = "ar";

        public static void SetCultureForLanguage(string ltrLanguage)
        {
            DependencyService.Get<ILocalize>().SetLocale(new CultureInfo(ltrLanguage));

        }

        public static string GetCultureForLanguage()
        {
            return DependencyService.Get<ILocalize>().GetCurrentCultureInfo().Name;
        }

    }

}
