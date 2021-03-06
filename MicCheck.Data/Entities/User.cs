﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicCheck.Data.Entities
{
    public class User
    {
        public User()
        {
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Hometown { get; set; }

        [Required]
        public string HashedPassword { get; set; }
    }
}
