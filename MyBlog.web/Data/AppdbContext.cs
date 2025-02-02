using Microsoft.EntityFrameworkCore;


namespace MyBlog.web.Data
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // اینجا مدل‌هایی که می‌خواهی در دیتابیس داشته باشی رو اضافه می‌کنی
        public DbSet<User> Users { get; set; }
    }
}
