namespace CodeFirstExistingDBDemo.Migrations
{
    using System;
    using System.Collections.ObjectModel;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstExistingDBDemo.PlutoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirstExistingDBDemo.PlutoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //context.Authors.AddOrUpdate(a => a.Name,
            //    new Author
            //    {
            //        Name = "Kumar",
            //        Courses = new Collection<Course>()
            //        {
            //            new Course() { Name = "SqlServer", Description = "SqlDesc" },
            //            new Course() { Name = "Firebase", Description = "FirebaseDesc" }
            //        }
            //    });
        }
    }
}
