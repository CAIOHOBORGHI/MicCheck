using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicCheck.Data.Entities
{
    public class MediaType
    {
        public MediaType()
        {
            PostMedias = new HashSet<PostMedia>();
        }

        [Key]
        public int MediaTypeId { get; set; }

        [Required]
        public string Type { get; set; }

        public virtual ICollection<PostMedia> PostMedias { get; private set; }
    }
}