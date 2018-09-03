using System.Data.Entity.ModelConfiguration;

namespace CodeFirstExistingDBDemo.EFConfigurations
{
    public class CourseConfiguration : EntityTypeConfiguration<Course>
    {
        public CourseConfiguration()
        {
            Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(255);


            HasMany(c => c.Tags)
           .WithMany(t => t.Courses)
           .Map(m => m.ToTable("CourseTags").MapLeftKey("CourseId").MapRightKey("TagId"));


            HasRequired(c => c.Author)
            .WithMany(a => a.Courses)
            .HasForeignKey(c => c.AuthorId)
            .WillCascadeOnDelete(false);


            HasRequired(c => c.Cover)
            .WithRequiredPrincipal(c => c.Course);
        }
    }
}
