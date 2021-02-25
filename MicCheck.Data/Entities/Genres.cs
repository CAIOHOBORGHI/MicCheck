using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicCheck.Data.Entities
{
    public class Genre
    {
        public Genre()
        {
            BandGenres = new HashSet<BandGenre>();
            FanFavoriteGenres = new HashSet<FanFavoriteGenre>();
        }

        [Key]
        public int GenreId { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<BandGenre> BandGenres { get; set; }
        public virtual ICollection<FanFavoriteGenre> FanFavoriteGenres { get; set; }
    }
}