using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System.Windows.Input;
using TravelGuideApp.Models.Card;
using TravelGuideApp.Services.Abstract.Card;
using TravelGuideApp.Views;

namespace TravelGuideApp.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        #region Fields

        private readonly INavigationService _navigationService;
        private readonly ILoginService _loginService;
        private readonly IPageDialogService _pageDialogService;

        #endregion

        #region Properties

        private LoginModel _LoginModel = new LoginModel();
        public LoginModel LoginModel
        {
            get { return _LoginModel; }
            set
            {
                _LoginModel = value;
                RaisePropertyChanged();
            }
        }

        private User _CreateUser = new User();
        public User CreateUser
        {
            get { return _CreateUser; }
            set
            {
                _CreateUser = value;
                RaisePropertyChanged();
            }
        }

        private string _ForgetEmail;
        public string ForgetEmail
        {
            get { return _ForgetEmail; }
            set
            {
                _ForgetEmail = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region Ctors

        public LoginPageViewModel(INavigationService navigationService,
                                  ILoginService loginService,
                                  IPageDialogService pageDialogService) : base(navigationService)
        {
            _navigationService = navigationService;
            _loginService = loginService;
            _pageDialogService = pageDialogService;
        }

        #endregion

        #region Commands

        public ICommand LoginCommand => new DelegateCommand(() =>
        {


        });

        public ICommand LoginClearCommand => new DelegateCommand(() =>
        {
            LoginModel.Clear();
        });


        public ICommand RegisterCommand => new DelegateCommand<User>(async (user) =>
        {
            await _navigationService.NavigateAsync(nameof(RegisterPage));
        });

        public ICommand ForgetPassword => new DelegateCommand(() =>
        {

        });


        #endregion

    }
}
