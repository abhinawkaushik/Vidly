using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.DTO
{
    public class MoviesDTO
    {
        public int ID { get; set; }        
        public string Name { get; set; }
        public int GenreID { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public DateTime? DateAdded { get; set; }                
        public int NumberInStock { get; set; }
    }
}