using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AuthAPI.Application.Interfaces
{
    public interface ICurrentUserService
    {
        string? UserId { get; }
        string? UserName { get; }
        IEnumerable<Claim> Claims { get; }
        bool IsAuthenticated { get; }
        bool IsInRole(string role);
    }
}
