using System.ComponentModel.DataAnnotations;

namespace FagestKeyGenerator.WebAPP.Models
{
    public class LoginRequest:LoginViewModel
    {
      
        public bool RememberMe { get; set; }
    }
}