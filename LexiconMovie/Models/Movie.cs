using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMovie.Models
{
    public class Movie
    {
        //Id
        public int Id { get; set; }

        //Title
        [Required]
        [StringLength(30)]
        public string  Title { get; set; }

        //ReleaseDate
        [DataType(DataType.Date)]
        [Display(Name = "Release date")]
        public DateTime ReleaseDate { get; set; }

        //Genre
        [Required]
        public Genre Genre { get; set; }

        //Rating
        [Range(1, 5)]
        public float Rating { get; set; }
    }
}
