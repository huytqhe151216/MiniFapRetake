using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MiniFapAPI.Models;

namespace MiniFapAPI.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Subject> subjects { set; get; }
        public DbSet<Student> students { set; get; }
        public DbSet<Course> courses { set; get; }
        public DbSet<Lecture> lectures { set; get; }
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Bỏ tiền tố AspNet của các bảng: mặc định các bảng trong IdentityDbContext có
            // tên với tiền tố AspNet như: AspNetUserRoles, AspNetUser ...
            // Đoạn mã sau chạy khi khởi tạo DbContext, tạo database sẽ loại bỏ tiền tố đó
            foreach (var entityType in builder.Model.GetEntityTypes ())
            {
                var tableName = entityType.GetTableName ();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }
        }

    }
}
