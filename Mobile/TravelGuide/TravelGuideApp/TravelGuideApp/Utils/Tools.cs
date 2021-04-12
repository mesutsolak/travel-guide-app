using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using Xamarin.Forms;

namespace TravelGuideApp.Utils
{
    public class Tools
    {

        private static ISettings AppSettings => CrossSettings.Current;

        private static bool _IsTapEnabled = true;
        public static bool IsTapEnabled
        {
            get { return _IsTapEnabled; }
            set
            {
                _IsTapEnabled = value;
                if (value == false)
                    Device.StartTimer(TimeSpan.FromSeconds(10), () => { _IsTapEnabled = true; return false; });
            }
        }

        public static string LanguageSettings
        {
            get
            {
                var value = AppSettings.GetValueOrDefault(Constant.LANGUAGE_SETTINGS_KEY, String.Empty);
                return String.IsNullOrEmpty(value) == true ? "tr-TR" : value;
            }
            set
            {
                AppSettings.AddOrUpdateValue(Constant.LANGUAGE_SETTINGS_KEY, value);
            }
        }

    }
}
