using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeriesDB.Models
{
    public class Genre
    {
            public int Id { get; set; }
            public string Name { get; set; }


            public ICollection<Serie> Series { get; set; }
        
    }
}