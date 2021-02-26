﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicCheck.Data.Entities
{
    public class UserRole
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
