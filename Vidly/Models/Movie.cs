using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        
        public Genre Genre { get; set; }
        [Required]
        public int GenreID { get; set; }
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        [Display(Name = "Items in Stock")]
        public int NumberInStock { get; set; }
    }
}