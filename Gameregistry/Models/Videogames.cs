using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Gameregistry.Models
{
    public class Videogames
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(250)]
        public string Description { get; set; }

        [Required]
        [StringLength(20)]
        public string Genre { get; set; }

        [Required]
        public DateTime ReleaseYear { get; set; }

    }
}
