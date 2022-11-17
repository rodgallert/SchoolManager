using Microsoft.EntityFrameworkCore;
using SchoolManager.Domain.Model;

namespace SchoolManager.Data.Mapping
{
    public static class StudentMapping
    {
        public static void Map(ModelBuilder builder)
        {
            builder.Entity<Student>()
                .HasKey(x => x.Id);

            builder.Entity<Student>()
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Entity<Student>()
                .Property(x => x.BirthDate)
                .IsRequired();

            builder.Entity<Student>()
                .Property(x => x.Document)
                .IsRequired();

            builder.Entity<Student>()
                .Property(x => x.Phone1)
                .IsRequired()
                .HasMaxLength(20);

            builder.Entity<Student>()
                .Property(x => x.Phone2)
                .HasMaxLength(20);

            builder.Entity<Student>()
                .Property(x => x.MotherName)
                .HasMaxLength(100);

            builder.Entity<Student>()
                .Property(x => x.FatherName)
                .HasMaxLength(100);

            builder.Entity<Student>()
                .Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(150);

            builder.Entity<Student>()
                .Property(x => x.Active)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Entity<Student>()
                .Property(x => x.UserId)
                .IsRequired();

            builder.Entity<Student>()
                .Property(x => x.ClassId)
                .IsRequired();

            builder.Entity<Student>()
                .HasOne(x => x.User)
                .WithMany();

            builder.Entity<Student>()
                .HasOne(x => x.Class)
                .WithMany(x => x.Students)
                .HasForeignKey(x => x.ClassId);

            builder.Entity<Student>()
                .HasMany(x => x.Activities)
                .WithOne(x => x.Student)
                .HasForeignKey(x => x.ActivityId);
        }
    }
}
