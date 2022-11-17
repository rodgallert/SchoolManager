using Microsoft.EntityFrameworkCore;
using SchoolManager.Domain.Model;

namespace SchoolManager.Data.Mapping
{
    public static class GradeMapping
    {
        public static void Map(ModelBuilder builder)
        {
            builder.Entity<Grade>()
                .HasKey(x => x.Id);

            builder.Entity<Grade>()
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Entity<Grade>()
                .Property(x => x.Active)
                .HasDefaultValue(true)
                .IsRequired();

            builder.Entity<Grade>()
                .HasMany(x => x.Subjects)
                .WithMany(x => x.Grades);

            builder.Entity<Grade>()
                .HasMany(x => x.Classes)
                .WithOne(x => x.Grade)
                .HasForeignKey(x => x.GradeId);
        }
    }
}
