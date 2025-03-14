using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthAPI.Domain.Interfaces
{
    public interface IAuthService
    {
        Task<(bool Succeeded, string Message, object Token)> LoginAsync(string email, string password, bool rememberMe);
        Task<(bool Succeeded, string Message)> RegisterAsync(string firstName, string lastName, string email, string username, string password);
        Task<(bool Succeeded, string Message, object Token)> RefreshTokenAsync(string accessToken, string refreshToken);
        Task<bool> RevokeTokenAsync(string username);
    }
}
