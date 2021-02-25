using System;
using System.ComponentModel.DataAnnotations;

namespace MicCheck.Data.Entities
{
    public class FanBandRelathionship
    {

        [Key]
        public Guid Id { get; set; }

        [Required]
        public Band Band { get; set; }

        [Required]
        public Fan Fan { get; set; }

        [Required]
        public bool Liked { get; set; }

        [Required]
        // With this column we are able to re-suggest unliked bands for a user after configured time
        public DateTime ChoiceDate { get; set; }
    }
}