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

            var actors = new List<Actor>
            {
            new Actor{FirstName="Matthias", LastName="Schoenaerts", BirthDate=DateTime.Parse("1977-12-08"), Street="Kerkstraat 55", ZipCode="2060", City="Antwerpen"},
            new Actor{FirstName="Al", LastName="Pacino", BirthDate=DateTime.Parse("1955-12-08"), Street="Zandpoortvest 55", ZipCode="2800", City="Mechelen"},
            new Actor{FirstName="Matthew", LastName="Fox", BirthDate=DateTime.Parse("1976-05-01"), Street="Grote Markt 55", ZipCode="2800", City="Mechelen"},
            new Actor{FirstName="John", LastName="Lennon", BirthDate=DateTime.Parse("1987-12-08"), Street="Rue de la gare 55", ZipCode="1000", City="Brussel"}



          
            };

            genres.ForEach(s => context.Genres.Add(s));
            actors.ForEach(x => context.Actors.Add(x));
            context.SaveChanges();
        }
    }
}