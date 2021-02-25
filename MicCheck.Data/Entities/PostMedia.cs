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
        public Guid PostMediaId { get; set; }

        [Required]
        public Guid PostId { get; set; }
        public Post Post { get; set; }

        [Required]
        public int MediaTypeId { get; set; }
        public MediaType MediaType { get; set; }

        [Required]
        public string MediaPath { get; set; }
    }
}