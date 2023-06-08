using FagestKeyGenerator.WebAPP.Models;
using System.Threading.Tasks;

namespace FagestKeyGenerator.WebAPP.Services.Interfaces.Login
{
    public interface IAuthService
    {
        Task Login(LoginRequest loginRequest);
        Task Register(RegisterRequest registerRequest);
        Task Logout();
        Task<CurrentUser> CurrentUserInfo();
    }
}