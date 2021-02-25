using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicCheck.Data.Entities
{
    public class SocialMedia
    {
        public SocialMedia()
        {
            BandSocialMedias = new HashSet<BandSocialMedia>();
        }

        [Key]
        public int SocialMediaId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Domain { get; set; }

        public virtual ICollection<BandSocialMedia> BandSocialMedias { get; private set; }
    }
}