using Microsoft.AspNetCore.Identity;

namespace MagicVillAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
