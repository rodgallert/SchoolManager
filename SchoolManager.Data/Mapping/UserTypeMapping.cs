using Microsoft.EntityFrameworkCore;
using SchoolManager.Domain.Model;

namespace SchoolManager.Data.Mapping
{
    public static class UserTypeMapping
    {
        public static void Map(ModelBuilder builder)
        {
            builder.Entity<UserType>()
                .HasKey(x => x.Id);

            builder.Entity<UserType>()
                .Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Entity<UserType>()
                .Property(x => x.Description)
                .HasMaxLength(100)
                .IsRequired();

            builder.Entity<UserType>()
                .Property(x => x.Active)
                .HasDefaultValue(true)
                .IsRequired();
        }
    }
}
