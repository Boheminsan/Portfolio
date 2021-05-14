using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.WebUI.Models {
    public class LoginModel {
        [Required]
        [UIHint ("email")]
        public string Email { get; set; }

        [Required]
        [UIHint ("password")]
        public string Password { get; set; }
    }
}