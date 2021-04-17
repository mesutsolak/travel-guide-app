using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using TravelGuideApp.Models.App;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelGuideApp.Utils.MarkupExtensions
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        private readonly CultureInfo ci = new CultureInfo(SystemInfo.LanguageSetting);
        static readonly Lazy<ResourceManager> ResMgr = new Lazy<ResourceManager>(() => new ResourceManager(Constant.ResourceId, IntrospectionExtensions.GetTypeInfo(typeof(TranslateExtension)).Assembly));
        public string Text { get; set; }
        public string TextTransform { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
                return String.Empty;

            var translation = ResMgr.Value.GetString(Text, ci);

            if (translation == null)
            {
                throw new ArgumentException(string.Format("Key '{0}' was not found in resources '{1}' for culture '{2}'.", Text, Constant.ResourceId, ci.Name));
            }

            if (TextTransform == Constant.TEXT_TRANSFORM_UPPERCASE)
            {
                translation = translation.ToUpper();
            }
            else if (TextTransform == Constant.TEXT_TRANSFORM_LOWERCASE)
            {
                translation = translation.ToLower();
            }

            return translation;
        }
    }
}
