namespace TravelGuideApp.Models
{
    public class LoginModel : BaseModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public override void Clear()
        {
            UserName = null;
            Password = null;
        }
    }
}
