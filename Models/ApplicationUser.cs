using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IdentityAndDataProtection.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [EmailAddress]
        public override string Email { get; set; } = string.Empty;
    }
}