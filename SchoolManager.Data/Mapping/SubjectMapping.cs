using Microsoft.EntityFrameworkCore;
using SchoolManager.Domain.Model;

namespace SchoolManager.Data.Mapping
{
    public static class SubjectMapping
    {
        public static void Map(ModelBuilder builder)
        {
            builder.Entity<Subject>()
                .HasKey(x => x.Id);

            builder.Entity<Subject>()
                .Property(x => x.Name)
                .IsRequired();

            builder.Entity<Subject>()
                .Property(x => x.Description)
                .IsRequired();

            builder.Entity<Subject>()
                .Property(x => x.SchoolHours)
                .HasPrecision(2)
                .IsRequired();

            builder.Entity<Subject>()
                .Property(x => x.Active)
                .HasDefaultValue(true)
                .IsRequired();

            builder.Entity<Subject>()
                .HasMany(x => x.Activities)
                .WithOne(x => x.Subject)
                .HasForeignKey(x => x.SubjectId);

            builder.Entity<Subject>()
                .HasMany(x => x.Grades)
                .WithMany(x => x.Subjects);
        }
    }
}
