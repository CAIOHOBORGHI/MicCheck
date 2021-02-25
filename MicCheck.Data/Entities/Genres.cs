using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicCheck.Data.Entities
{
    public class Genre
    {
        public Genre()
        {
            Bands = new HashSet<Band>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Band> Bands { get; set; }
    }
}