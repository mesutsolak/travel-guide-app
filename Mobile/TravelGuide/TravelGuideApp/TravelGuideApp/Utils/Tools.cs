using System;
using Xamarin.Forms;

namespace TravelGuideApp.Utils
{
    public class Tools
    {
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
    }
}
