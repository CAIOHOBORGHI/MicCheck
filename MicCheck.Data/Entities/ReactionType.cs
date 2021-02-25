using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicCheck.Data.Entities
{
    public class ReactionType
    {
        public ReactionType()
        {
            ReelsReactions = new HashSet<ReelReaction>();
            PostsReactions = new HashSet<PostReaction>();
        }

        [Key]
        public int ReactionTypeId { get; set; }

        [Required]
        public string EmojiCode { get; set; }

        [Required]
        public string Type { get; set; }

        public virtual ICollection<ReelReaction> ReelsReactions { get; set; }
        public virtual ICollection<PostReaction> PostsReactions { get; set; }
    }
}