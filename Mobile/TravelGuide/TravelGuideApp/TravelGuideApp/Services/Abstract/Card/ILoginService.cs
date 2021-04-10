using System.Threading.Tasks;
using TravelGuideApp.Models.Card;

namespace TravelGuideApp.Services.Abstract.Card
{
    public interface ILoginService
    {
        Task<bool> ForgetPasswordAsync(string email);
        Task<int> CreateUserAsync(User user);
        Task<bool> LoginAsync(LoginModel loginModel);
    }
}
