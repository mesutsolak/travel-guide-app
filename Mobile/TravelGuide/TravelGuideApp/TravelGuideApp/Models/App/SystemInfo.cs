using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using TravelGuideApp.Utils;

namespace TravelGuideApp.Models.App
{
    public class SystemInfo
    {
        private static ISettings AppSettings => CrossSettings.Current;

        public static string LanguageSetting
        {
            get
            {
                var value = AppSettings.GetValueOrDefault(Constant.LANGUAGE_KEY, String.Empty);
                return String.IsNullOrEmpty(value) == true ? "tr-TR" : value;
            }
            set
            {
                AppSettings.AddOrUpdateValue(Constant.LANGUAGE_KEY, value);
            }
        }

    }
}
