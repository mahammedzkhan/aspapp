using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SeriesDB.Models
{
    public class SerieContext
         : DbContext
    {
        public IDbSet<Genre> Genres { get; set; }
        public IDbSet<Serie> Series { get; set; }


    }
}