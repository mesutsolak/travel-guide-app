using System.Threading.Tasks;
using TravelGuideApp.Models;

namespace TravelGuideApp.Services.Abstract
{
    public interface ILoginService
    {
        Task<bool> ForgetPasswordAsync(string email);
        Task<int> CreateUserAsync(User user);
        Task<bool> LoginAsync(LoginModel loginModel);
    }
}
