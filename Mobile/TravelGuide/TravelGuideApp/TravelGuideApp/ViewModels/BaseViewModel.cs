using Prism.AppModel;
using Prism.Mvvm;
using Prism.Navigation;

namespace TravelGuideApp.ViewModels
{
    public class BaseViewModel : BindableBase, IInitialize, INavigationAware, IDestructible, IPageLifecycleAware
    {

        protected INavigationService NavigationService { get; private set; }

        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public void Destroy()
        {

        }

        public void Initialize(INavigationParameters parameters)
        {
            
        }

        public void OnAppearing()
        {
           
        }

        public void OnDisappearing()
        {
             
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
             
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            
        }
    }
}
