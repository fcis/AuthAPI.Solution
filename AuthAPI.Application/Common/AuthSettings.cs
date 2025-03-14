using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthAPI.Application.Common
{
    public class AuthSettings
    {
        public string Key { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;
        public double TokenExpiryInMinutes { get; set; } = 60;
        public double ExtendedTokenExpiryInMinutes { get; set; } = 1440; // 24 hours
        public double RefreshTokenExpiryInDays { get; set; } = 7;
        public int MaxLoginAttempts { get; set; } = 3;
        public int BlockDurationInMinutes { get; set; } = 15;
    }
}
