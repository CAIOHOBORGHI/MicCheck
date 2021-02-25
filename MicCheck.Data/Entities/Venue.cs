
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicCheck.Data.Entities
{
    public class Venue
    {
        public Venue()
        {
            Shows = new HashSet<Show>();
        }

        [Key]
        public Guid VenueId { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(120)]
        public string Description { get; set; }

        [Required]
        public Guid AddressId { get; set; }
        public Address Address { get; set; }

        public virtual ICollection<Show> Shows { get; private set; }

    }
}