using System;
using System.ComponentModel.DataAnnotations;

namespace MicCheck.Data.Entities
{
    public class FanBandRelationship
    {

        [Key]
        public int FanBandRelationshipId { get; set; }

        [Required]
        public int BandId { get; set; }

        public Band Band { get; set; }

        [Required]
        public int FanId { get; set; }

        public Fan Fan { get; set; }

        [Required]
        public bool Liked { get; set; }

        [Required]
        // With this column we are able to re-suggest unliked bands for a user after configured time
        public DateTime ChoiceDate { get; set; }
    }
}