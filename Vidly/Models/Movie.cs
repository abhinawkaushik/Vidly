﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }        
        public Genre Genre { get; set; }
        [Display(Name = "Genre")]
        [Required]
        public int GenreID { get; set; }
        [Display(Name = "Release Date")]
        [Required]
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        [Display(Name = "Items in Stock")]
        [Range(1,20)]
        [Required]
        [CannotBeZero]
        public int NumberInStock { get; set; }
    }
}