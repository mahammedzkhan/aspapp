namespace SeriesDB.Migrations
{
    using SeriesDB.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SeriesDB.Models.SerieContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "SeriesDB.Models.SerieContext";
        }

        protected override void Seed(SeriesDB.Models.SerieContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var genres = new List<Genre>
            {
            new Genre{Name="Horror"},
            new Genre{Name="Sci-Fi"},
            new Genre{Name="Drama"},
            new Genre{Name="Thriller"}

          
            };
            genres.ForEach(s => context.Genres.Add(s));
            context.SaveChanges();

            var actors = new List<Actor>
            {
            new Actor{FirstName="Matthias", LastName="Schoenaerts", BirthDate=DateTime.Parse("1977-12-08"), Street="Kerkstraat 55", ZipCode="2060", City="Antwerpen"},
            new Actor{FirstName="Al", LastName="Pacino", BirthDate=DateTime.Parse("1955-12-08"), Street="Zandpoortvest 55", ZipCode="2800", City="Mechelen"},
            new Actor{FirstName="Matthew", LastName="Fox", BirthDate=DateTime.Parse("1976-05-01"), Street="Grote Markt 55", ZipCode="2800", City="Mechelen"},
            new Actor{FirstName="John", LastName="Lennon", BirthDate=DateTime.Parse("1987-12-08"), Street="Rue de la gare 55", ZipCode="1000", City="Brussel"}



          
            };
            actors.ForEach(x => context.Actors.Add(x));
            context.SaveChanges();


        }
    }
}
