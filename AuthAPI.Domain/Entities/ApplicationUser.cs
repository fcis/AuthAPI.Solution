using Microsoft.AspNetCore.Identity;

namespace AuthAPI.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public bool IsBlocked { get; set; } = false;
        public int LoginFailedCount { get; set; } = 0;
        public DateTime? BlockedUntil { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
