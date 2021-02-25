using System;
using System.ComponentModel.DataAnnotations;

namespace MicCheck.Data.Entities
{
    public class FanBandRelationship
    {

        [Key]
        public Guid FanBandRelationshipId { get; set; }

        [Required]
        public string BandId { get; set; }

        public Band Band { get; set; }

        [Required]
        public string FanId { get; set; }

        public Fan Fan { get; set; }

        [Required]
        public bool Liked { get; set; }

        [Required]
        // With this column we are able to re-suggest unliked bands for a user after configured time
        public DateTime ChoiceDate { get; set; }
    }
}