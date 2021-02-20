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

        public virtual void Destroy()
        {

        }

        public virtual void Initialize(INavigationParameters parameters)
        {
            
        }

        public virtual void OnAppearing()
        {
           
        }

        public virtual void OnDisappearing()
        {
             
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
             
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
            
        }
    }
}
