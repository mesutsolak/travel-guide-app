using System.Threading.Tasks;
using TravelGuideApp.Models;
using TravelGuideApp.Services.Abstract;

namespace TravelGuideApp.Services.Concrete
{
    public class LoginService : ILoginService
    {
        public Task<int> CreateUserAsync(User user)
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
