using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicCheck.Data.Entities
{
    public class PostReaction
    {
        public PostReaction()
        {
        }

        [Key]
        public Guid PostReactionId { get; set; }

        [Required]
        public Guid PostId { get; set; }
        public Post Post { get; set; }

        [Required]
        public int FanId { get; set; }
        public Fan Fan { get; set; }


        [Required]
        public int ReactionTypeId { get; set; }
        public ReactionType ReactionType { get; set; }
    }
}