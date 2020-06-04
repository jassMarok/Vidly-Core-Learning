using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }
        
        [Required]
        [Display(Name = "Number in Stock")]
        public ulong NumberInStock { get; set; }
        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        public int? GenreId { get; set; }
    }
}
