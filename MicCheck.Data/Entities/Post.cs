using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicCheck.Data.Entities
{
    public class Post
    {
        public Post()
        {
            PostReactions = new HashSet<PostReaction>();
            PostMedias = new HashSet<PostMedia>();
        }

        [Key]
        public Guid PostId { get; set; }

        [Required]
        public string BandId { get; set; }
        public Band Band { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        public virtual ICollection<PostMedia> PostMedias { get; private set; }

        public virtual ICollection<PostReaction> PostReactions { get; private set; }
    }
}