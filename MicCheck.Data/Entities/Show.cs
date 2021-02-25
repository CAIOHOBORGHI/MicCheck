
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicCheck.Data.Entities
{
    public class Show
    {
        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public Band Band { get; set; }

        [Required]
        public Venue Venue { get; set; }

    }
}