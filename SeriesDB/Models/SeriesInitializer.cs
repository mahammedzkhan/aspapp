using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SeriesDB.Models
{
    public class SeriesInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SerieContext>
    {
        protected override void Seed(SerieContext context)
        {
            var genres = new List<Genre>
            {
            new Genre{Name="Horror"},
            new Genre{Name="Sci-Fi"},
            new Genre{Name="Drama"},
            new Genre{Name="Thriller"}

          
            };

            genres.ForEach(s => context.Genres.Add(s));
            context.SaveChanges();
        }
    }
}