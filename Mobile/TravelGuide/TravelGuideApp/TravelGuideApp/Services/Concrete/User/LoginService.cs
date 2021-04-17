using System.Threading.Tasks;
using TravelGuideApp.Models.Card;
using TravelGuideApp.Services.Abstract.Card;

namespace TravelGuideApp.Services.Concrete.Card
{
    public class LoginService : ILoginService
    {

        public Task<int> CreateUserAsync(User customer)
        {
            return null;
        }

        public Task<bool> ForgetPasswordAsync(string email)
        {
            return null;
        }

        public Task<bool> LoginAsync(LoginModel loginModel)
        {
            return null;
        }
    }
}
