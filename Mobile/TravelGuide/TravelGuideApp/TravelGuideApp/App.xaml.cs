using Prism;
using Prism.Ioc;
using Prism.Unity;
using TravelGuideApp.Services.Abstract.Card;
using TravelGuideApp.Services.Concrete.Card;
using TravelGuideApp.ViewModels;
using TravelGuideApp.Views;
using Xamarin.Forms;

namespace TravelGuideApp
{
    public partial class App : PrismApplication
    {
        public App()
        {
            InitializeComponent();
        }

        public App(IPlatformInitializer platformInitializer) : base(platformInitializer)
        {
            InitializeComponent();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterInstance(typeof(ILoginService), new LoginService());


            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();

        }

        protected async override void OnInitialized()
        {
            await NavigationService.NavigateAsync(nameof(LoginPage));
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
