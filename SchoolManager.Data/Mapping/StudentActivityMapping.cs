using Microsoft.EntityFrameworkCore;
using SchoolManager.Domain.Model;

namespace SchoolManager.Data.Mapping
{
    public static class StudentActivityMapping
    {
        public static void Map(ModelBuilder builder)
        {
            builder.Entity<StudentActivity>()
                .HasKey(x => x.Id);

            builder.Entity<StudentActivity>()
                .Property(x => x.IsDelivered)
                .HasDefaultValue(false)
                .IsRequired();

            builder.Entity<StudentActivity>()
                .Property(x => x.DeliveryDate)
                .IsRequired(false);

            builder.Entity<StudentActivity>()
                .Property(x => x.ReceivedGrade)
                .HasPrecision(2);

            builder.Entity<StudentActivity>()
                .HasOne(x => x.Activity)
                .WithMany(x => x.StudentActivities)
                .HasForeignKey(x => x.ActivityId)
                .IsRequired();

            builder.Entity<StudentActivity>()
                .HasOne(x => x.Student)
                .WithMany(x => x.Activities)
                .HasForeignKey(x => x.StudentId)
                .IsRequired();
        }
    }
}
