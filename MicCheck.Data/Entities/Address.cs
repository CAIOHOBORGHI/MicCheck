
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicCheck.Data.Entities
{
    // For demo purposes, I made this entity quite simple.
    public class Address
    {
        public Address()
        {
            Venues = new HashSet<Venue>();
        }

        [Key]
        public Guid AddressId { get; set; }

        [Required]
        public string City { get; set; }

        public string Complement { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        [StringLength(12)]
        public string ZIPCode { get; set; }

        public virtual ICollection<Venue> Venues { get; private set; } 

    }
}