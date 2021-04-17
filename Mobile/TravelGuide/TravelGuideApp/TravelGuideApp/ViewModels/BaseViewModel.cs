using Prism.AppModel;
using Prism.Mvvm;
using Prism.Navigation;

namespace TravelGuideApp.ViewModels
{
    public class BaseViewModel : BindableBase, IInitialize, INavigationAware, IDestructible, IPageLifecycleAware
    {

        protected INavigationService _navigationService { get; private set; }

        public BaseViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
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
