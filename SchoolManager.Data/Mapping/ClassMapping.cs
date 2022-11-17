using Microsoft.EntityFrameworkCore;
using SchoolManager.Domain.Model;

namespace SchoolManager.Data.Mapping
{
    public static class ClassMapping
    {
        public static void Map(ModelBuilder builder)
        {
            builder.Entity<Class>()
                .HasKey(x => x.Id);

            builder.Entity<Class>()
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Entity<Class>()
                .Property(x => x.Year)
                .IsRequired();

            builder.Entity<Class>()
                .Property(x => x.Active)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Entity<Class>()
                .HasOne(x => x.Grade)
                .WithMany(x => x.Classes);
        }
    }
}
