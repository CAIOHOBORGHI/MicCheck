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

        [Required]
        public int BandId { get; set; }

        public Band Band { get; set; }


        [Required]
        public int SocialMediaId { get; set; }

        public SocialMedia SocialMedia { get; set; }


        [Required]
        public string Url { get; set; }
    }
}