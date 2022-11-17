using Microsoft.EntityFrameworkCore;
using SchoolManager.Domain.Model;

namespace SchoolManager.Data.Mapping
{
    public static class ActivtyMapping
    {
        public static void Map(ModelBuilder builder)
        {
            builder.Entity<Activity>()
                .HasKey(x => x.Id);

            builder.Entity<Activity>()
                .Property(x => x.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Entity<Activity>()
                .Property(x => x.Description)
                .HasMaxLength(1000);

            builder.Entity<Activity>()
                .Property(x => x.DueDate)
                .IsRequired();

            builder.Entity<Activity>()
                .Property(x => x.MaxGrade)
                .IsRequired()
                .HasPrecision(2);

            builder.Entity<Activity>()
                .Property(x => x.Active)
                .HasDefaultValue(true)
                .IsRequired();

            builder.Entity<Activity>()
                .Property(x => x.RegisterDate)
                .IsRequired();

            builder.Entity<Activity>()
                .Property(x => x.SubjectId)
                .IsRequired();

            builder.Entity<Activity>()
                .Property(x => x.TeacherId)
                .IsRequired();

            builder.Entity<Activity>()
                .HasOne(x => x.Subject)
                .WithMany(x => x.Activities);

            builder.Entity<Activity>()
                .HasOne(x => x.Teacher)
                .WithMany(x => x.Activities);
        }
    }
}
