using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicCheck.Data.Entities
{
    public class PostMedia
    {
        public PostMedia()
        {
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public Post Post { get; set; }

        [Required]
        public MediaType MediaType { get; set; }

        [Required]
        public string MediaPath { get; set; }
    }
}