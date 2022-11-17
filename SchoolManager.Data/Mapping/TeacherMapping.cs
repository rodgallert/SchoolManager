using Microsoft.EntityFrameworkCore;
using SchoolManager.Domain.Model;

namespace SchoolManager.Data.Mapping
{
    public static class TeacherMapping
    {
        public static void Map(ModelBuilder builder)
        {
            builder.Entity<Teacher>()
                .HasKey(x => x.Id);

            builder.Entity<Teacher>()
                .Property(x => x.Name)
                .IsRequired();

            builder.Entity<Teacher>()
                .Property(x => x.Email)
                .IsRequired();

            builder.Entity<Teacher>()
                .Property(x => x.Active)
                .HasDefaultValue(true)
                .IsRequired();

            builder.Entity<Teacher>()
                .HasOne(x => x.User)
                .WithMany();

            builder.Entity<Teacher>()
                .HasMany(x => x.Subjects)
                .WithMany(x => x.Teachers);

            builder.Entity<Teacher>()
                .HasMany(x => x.Activities)
                .WithOne(x => x.Teacher)
                .HasForeignKey(x => x.SubjectId);
        }
    }
}
