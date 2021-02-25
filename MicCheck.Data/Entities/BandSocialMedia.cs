using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicCheck.Data.Entities
{
    public class BandSocialMedia
    {
        public BandSocialMedia()
        {
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public Band Band { get; set; }

        [Required]
        public SocialMedia SocialMedia { get; set; }

        [Required]
        public string Url { get; set; }
    }
}