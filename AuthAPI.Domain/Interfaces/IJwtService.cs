using AuthAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AuthAPI.Domain.Interfaces
{
    public interface IJwtService
    {
        Task<object> GenerateTokenAsync(ApplicationUser user, bool extendedExpiry = false);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
