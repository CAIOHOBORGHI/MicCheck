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
        public Guid Id { get; set; }

        [Required]
        public Post Post { get; set; }

        [Required]
        public ReactionType ReactionType { get; set; }
    }
}