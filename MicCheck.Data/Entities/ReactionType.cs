using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicCheck.Data.Entities
{
    public class ReactionType
    {
        public ReactionType()
        {
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string EmojiCode { get; set; }

        [Required]
        public string Type { get; set; }
    }
}