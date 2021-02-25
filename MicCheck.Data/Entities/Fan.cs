using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicCheck.Data.Entities
{
    public class Fan
    {
        public Fan()
        {
            FavoriteGenres = new HashSet<Genre>();
            MatchedBands = new HashSet<Band>();
            PostReactions = new HashSet<PostReaction>();
            Reels = new HashSet<Reel>();
        }

        [Required]
        public string BirthCountry { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public virtual ICollection<Genre> FavoriteGenres { get; private set; }
        public virtual ICollection<Band> MatchedBands { get; private set; }
        public virtual ICollection<Reel> Reels { get; private set; }
        public virtual ICollection<PostReaction> PostReactions { get; private set; }
    }
}