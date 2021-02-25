using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicCheck.Data.Entities
{
    public class Reel
    {
        public Reel()
        {
            Reactions = new HashSet<ReelReaction>();
        }

        [Key]
        public Guid ReelId { get; set; }

        [Required]
        public string BandId { get; set; }
        public Band Band { get; set; }

        [Required]
        public string FanId { get; set; }
        public Fan Fan { get; set; }


        [Required]
        public string VideoPath { get; set; }

        public virtual ICollection<ReelReaction> Reactions { get; private set; }
    }
}