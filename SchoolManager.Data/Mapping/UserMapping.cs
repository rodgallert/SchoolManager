using Microsoft.EntityFrameworkCore;
using SchoolManager.Domain.Model;

namespace SchoolManager.Data.Mapping
{
    public static class UserMapping
    {
        public static void Map(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasKey(x => x.Id);

            builder.Entity<User>()
                .Property(x => x.Username)
                .HasMaxLength(50)
                .IsRequired();

            builder.Entity<User>()
                .Property(x => x.Password)
                .HasMaxLength(64)
                .IsRequired();

            builder.Entity<User>()
                .Property(x => x.Email)
                .HasMaxLength(50)
                .IsRequired();

            builder.Entity<User>()
                .Property(x => x.RecoveryKey)
                .HasMaxLength(64);

            builder.Entity<User>()
                .Property(x => x.Active)
                .HasDefaultValue(true)
                .IsRequired();

            builder.Entity<User>()
                .HasOne(x => x.UserType)
                .WithMany()
                .HasForeignKey(x => x.UserTypeId);
        }
    }
}
