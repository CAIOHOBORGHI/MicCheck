using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicCheck.Data.Entities
{
    public class Band
    {
        public Band()
        {
            Fans = new HashSet<Fan>();
            GenreTags = new HashSet<Genre>();
            Posts = new HashSet<Post>();
            SocialMedias = new HashSet<BandSocialMedia>();
        }

        // *** Properties that will be loaded from select ***
        // - FansCount
        // - FansReels


        [Required]
        [StringLength(120)]
        public string Description { get; set; }

        [Required]
        public string HomeTown { get; set; }

        public string PicturePath { get; set; }
        public string PresentationAudioPath { get; set; }
        public string VideoClipPath { get; set; }


        public virtual ICollection<Fan> Fans { get; private set; }
        public virtual ICollection<Genre> GenreTags { get; private set; }
        public virtual ICollection<Post> Posts { get; private set; }
        public virtual ICollection<BandSocialMedia> SocialMedias { get; private set; }
    }
}