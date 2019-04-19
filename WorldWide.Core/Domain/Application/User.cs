using Microsoft.AspNetCore.Identity;

namespace WorldWide.Core.Domain.Application
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public string PreferredName { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsSalesperson { get; set; }
        public string UserPreferences { get; set; }
    }
}
