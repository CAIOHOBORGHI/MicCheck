using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MicCheck.API.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "User name can't be empty!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "User email can't be empty!")]
        [EmailAddress(ErrorMessage = "User email is invalid!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "User password can't be empty!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "User role is required!")]
        public string Role { get; set; }
    }
}
