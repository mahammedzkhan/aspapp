namespace SeriesDB.Migrations
{
    using SeriesDB.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SeriesDB.Models.SerieContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
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

            context.Genres.AddOrUpdate(
                g => g.Name,
            new Genre { Name="Horror" },
            new Genre {Name="Sci-Fi"},
            new Genre {Name="Drama"},
            new Genre {Name="Thriller"}

          
            );

        }
    }
}
