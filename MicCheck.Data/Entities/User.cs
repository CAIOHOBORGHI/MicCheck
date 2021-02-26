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
            Bands = new HashSet<Band>();
            Fans = new HashSet<Fan>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string HomeTown { get; set; }

        [Required]
        public string HashedPassword { get; set; }

        //Using role as a string for demo purposes
        [Required]
        public string Role { get; set; }

        public virtual ICollection<Band> Bands { get; set; }
        public virtual ICollection<Fan> Fans { get; set; }
    }
}