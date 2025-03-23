using System.ComponentModel.DataAnnotations;

namespace IdentityAndDataProtection.Models
{
    public class RegisterModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MinLength(6, ErrorMessage = "Şifre en az 6 karakter olmalıdır.")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d@$!%*?&]{6,}$", ErrorMessage = "Şifre en az bir harf ve bir rakam içermelidir.")]
        public string Password { get; set; } = string.Empty;
    }

}

