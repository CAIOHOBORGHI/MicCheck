using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MicCheck.Shared.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name can't be empty!")]
        [MinLength(3, ErrorMessage = "Minimum lenght of name is 3 characters!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email can't be empty!")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Email is invalid!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Hometown can't be empty!")]
        public string Hometown { get; set; }

        [Required(ErrorMessage = "Password can't be empty!")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*\d)(?=.*[#$^+=!*()@%&]).{6,}$", ErrorMessage = "Password must meet requirements!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords must match!")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Role is required!")]
        public virtual string Role { get; set; }
    }
}
