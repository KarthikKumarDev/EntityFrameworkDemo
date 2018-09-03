namespace CodeFirstExistingDBDemo
{
    using CodeFirstExistingDBDemo.EFConfigurations;
    using System;
    using System.Data.Entity;

    public partial class PlutoContext : DbContext
    {
        public PlutoContext()
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CourseConfiguration());          
            
        }
    }
}
