using System.ComponentModel.DataAnnotations;

namespace kumariHostel.Models.Authentication.SignUp
{
    public class RegisterUser
    {
        [Required (ErrorMessage = "User Name is required")]

        public string? Username { get; set; }

        [EmailAddress]
        [Required (ErrorMessage = "Email is Required")]
        public string? Email {  get; set; }

        [Required (ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}
