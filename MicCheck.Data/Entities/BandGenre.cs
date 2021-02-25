using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicCheck.Data.Entities
{
    public class BandGenre
    {
        [Required]
        public string BandId { get; set; }
        public Band Band { get; set; }

        [Required]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }

    }
}
