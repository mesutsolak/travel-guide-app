using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelGuideApp.Utils.MarkupExtensions
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        private readonly CultureInfo ci = null;
        static readonly Lazy<ResourceManager> ResMgr = new Lazy<ResourceManager>(() => new ResourceManager(ResourceId, IntrospectionExtensions.GetTypeInfo(typeof(TranslateExtension)).Assembly));

        private const string ResourceId = "TravelGuideApp.Resx.AppResources";
        public string Text { get; set; }

        public string TextTransform { get; set; }

        public TranslateExtension()
        {
            //if (Utility.Utils.LanguageSettings == String.Empty)
            //    ci = CultureInfo.CurrentCulture;
            //else
            //    ci = new CultureInfo(Utility.Utils.LanguageSettings);

        }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
                return string.Empty;

            var translation = ResMgr.Value.GetString(Text, ci);

            if (translation == null)
            {
#if DEBUG
                throw new ArgumentException(
                    string.Format("Key '{0}' was not found in resources '{1}' for culture '{2}'.", Text, ResourceId, ci.Name),
                    "Text");
#endif
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
