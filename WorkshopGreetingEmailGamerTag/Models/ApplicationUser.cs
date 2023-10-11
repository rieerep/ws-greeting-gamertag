using Microsoft.AspNetCore.Identity;

namespace WorkshopGreetingEmailGamerTag.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? GamerTag { get; set; }

    }
}