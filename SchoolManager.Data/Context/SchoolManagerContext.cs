using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SchoolManager.Data.Mapping;
using SchoolManager.Domain.Model;

namespace SchoolManager.Data.Context
{
    public class SchoolManagerContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public SchoolManagerContext(DbContextOptions<SchoolManagerContext> context,
                                    IConfiguration configuration) : base(context)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseMySql(ServerVersion.AutoDetect(_configuration.GetConnectionString("conn")));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            ActivtyMapping.Map(builder);
            ClassMapping.Map(builder);
            GradeMapping.Map(builder);
            StudentActivityMapping.Map(builder);
            StudentMapping.Map(builder);
            SubjectMapping.Map(builder);
            TeacherMapping.Map(builder);
            UserMapping.Map(builder);
            UserTypeMapping.Map(builder);
        }

        #region datasets
        public DbSet<Activity> Activity { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<StudentActivity> StudentActivities { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserType> UserType { get; set; }
        #endregion
    }
}
