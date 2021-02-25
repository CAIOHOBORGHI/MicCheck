using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicCheck.Data.Entities
{
    public class FanFavoriteGenre
    {
        [Required]
        public string FanId { get; set; }
        public Fan Fan { get; set; }

        [Required]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }

    }
}
