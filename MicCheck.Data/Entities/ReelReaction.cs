using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicCheck.Data.Entities
{
    public class ReelReaction
    {
        public ReelReaction()
        {
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public Reel Reel { get; set; }

        [Required]
        public ReactionType ReactionType { get; set; }
    }
}