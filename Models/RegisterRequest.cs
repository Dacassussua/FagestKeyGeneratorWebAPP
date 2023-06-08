using System.ComponentModel.DataAnnotations;

namespace FagestKeyGenerator.WebAPP.Models
{
    public class RegisterRequest : LoginViewModel
    {
        [Required]
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match!")]
        public string PasswordConfirm { get; set; }
    }
}