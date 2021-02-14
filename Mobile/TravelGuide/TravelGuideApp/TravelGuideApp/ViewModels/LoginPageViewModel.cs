using Prism.Navigation;
using Prism.Services;
using TravelGuideApp.Services.Abstract;

namespace TravelGuideApp.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {

        #region Fields

        private readonly INavigationService _navigationService;
        private readonly ILoginService _loginService;
        private readonly IPageDialogService _pageDialogService;

        #endregion

        #region Ctors

        public LoginPageViewModel(INavigationService navigationService,
                                  ILoginService loginService,
                                  IPageDialogService pageDialogService) : base(navigationService) {
            _navigationService = navigationService;
            _loginService = loginService;
            _pageDialogService = pageDialogService;
        }

        #endregion

    }
}
