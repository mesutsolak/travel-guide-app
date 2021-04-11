namespace TravelGuideApp.Models.Card
{
    public class LoginModel : BaseModel
    {
        private string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set
            {
                _UserName = value;
                RaisePropertyChanged();
            }
        }

        private string _Password;
        public string Password
        {
            get { return _Password; }
            set
            {
                _Password = value;
                RaisePropertyChanged();
            }
        }

        public override void Clear()
        {
            UserName = string.Empty;
            Password = string.Empty;
        }
    }
}
