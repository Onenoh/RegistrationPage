using System.ComponentModel.DataAnnotations;
using System;

namespace RegistrationPage.Models
{
    public class CreateUser
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).{8,}$", ErrorMessage = "least 8 characters")]
        public string Password { get; set; }
        [ScaffoldColumn(false)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "PhoneNumber is required")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "DOB is required")]
        public DateTime DOB { get; set; }
    }
}
