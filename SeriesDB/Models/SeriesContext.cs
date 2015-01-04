using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SeriesDB.Models
{
    public class SeriesContext : DbContext
    {
    
        public SeriesContext() : base("name=SeriesContext")
        {
        }

        public System.Data.Entity.DbSet<SeriesDB.Models.Serie> Series { get; set; }
    
    }
}
