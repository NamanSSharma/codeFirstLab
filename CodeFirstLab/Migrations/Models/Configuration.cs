namespace CodeFirstLab.Migrations.Models
{
    using CodeFirstLab.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstLab.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Models";
        }

        protected override void Seed(CodeFirstLab.Models.ApplicationDbContext context)
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

            context.Provinces.AddOrUpdate(
               p => p.ProvinceName, DummyData.getProvinces().ToArray());

            context.SaveChanges();

            context.Cities.AddOrUpdate(
                c => c.CityName, DummyData.getCities(context).ToArray());

            context.SaveChanges();
        }
    }
}
