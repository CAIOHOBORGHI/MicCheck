using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MicCheck.API.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name can't be empty!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email can't be empty!")]
        [EmailAddress(ErrorMessage = "Email is invalid!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Hometown can't be empty!")]
        public string Hometown { get; set; }

        [Required(ErrorMessage = "Password can't be empty!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Role is required!")]
        public virtual string Role { get; set; }
    }
}
