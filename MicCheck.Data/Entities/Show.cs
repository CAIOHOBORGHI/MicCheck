
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicCheck.Data.Entities
{
    public class Show
    {
        [Key]
        public Guid ShowId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public int BandId { get; set; }
        public Band Band { get; set; }

        [Required]
        public Guid VenueId { get; set; }

        public Venue Venue { get; set; }

    }
}