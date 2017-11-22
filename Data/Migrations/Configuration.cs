using Domain.Entities;

namespace Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.FDMContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Data.FDMContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.SportDbSet.AddOrUpdate(
                    new Sport { SportId = 1, Name = "Atletismo" },
                    new Sport { SportId = 2, Name = "Baloncesto" },
                    new Sport { SportId = 3, Name = "Lucha" },
                    new Sport { SportId = 4, Name = "Karate" },
                    new Sport { SportId = 5, Name = "Levantamiento Pesas" },
                    new Sport { SportId = 6, Name = "Taek-Wond-Do" }
                );



        }
    }
}
