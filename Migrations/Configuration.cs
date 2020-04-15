namespace Guarderia.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Guarderia.Models.GuarderiaContext>
    {
        public Configuration()
        {
           AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            //Database.SetInitializer<Guarderia.Models.GuarderiaContext>(new DropCreateDatabaseIfModelChanges<Guarderia.Models.GuarderiaContext>());
        }

        protected override void Seed(Guarderia.Models.GuarderiaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
