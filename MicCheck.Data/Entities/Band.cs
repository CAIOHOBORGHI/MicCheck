using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicCheck.Data.Entities
{
    public class Band
    {
        public Band()
        {
            FansReels = new HashSet<Reel>();
            FansRelationships = new HashSet<FanBandRelationship>();
            GenreTags = new HashSet<BandGenre>();
            Posts = new HashSet<Post>();
            SocialMedias = new HashSet<BandSocialMedia>();
            Shows = new HashSet<Show>();
        }

        [Key]
        public int BandId { get; set; }

        [Required]
        [StringLength(120)]
        public string Description { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        public string PicturePath { get; set; }
        public string PresentationAudioPath { get; set; }
        public string VideoClipPath { get; set; }


        public virtual ICollection<FanBandRelationship> FansRelationships { get; private set; }
        public virtual ICollection<Reel> FansReels { get; private set; }
        public virtual ICollection<BandGenre> GenreTags { get; private set; }
        public virtual ICollection<Post> Posts { get; private set; }
        public virtual ICollection<BandSocialMedia> SocialMedias { get; private set; }
        public virtual ICollection<Show> Shows { get; private set; }
    }
}