using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicCheck.Data.Entities
{
    public class Fan
    {
        public Fan()
        {
            BandsRelationships = new HashSet<FanBandRelationship>();
            FavoriteGenres = new HashSet<FanFavoriteGenre>();
            PostReactions = new HashSet<PostReaction>();
            Reels = new HashSet<Reel>();
        }

        [Key]
        public string FanId { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        //[Required]
        //public string Email { get; set; }

        [Required]
        public string HomeTown { get; set; }

        [Required]
        public string Name { get; set; }

        public string PicturePath { get; set; }

        public string ProfileDescription { get; set; }


        //public virtual IdentityUser ApplicationUser { get; set; }

        public virtual ICollection<FanBandRelationship> BandsRelationships { get; set; }
        public virtual ICollection<FanFavoriteGenre> FavoriteGenres { get; private set; }
        public virtual ICollection<Reel> Reels { get; private set; }
        public virtual ICollection<PostReaction> PostReactions { get; private set; }
    }
}