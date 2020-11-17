using Microsoft.EntityFrameworkCore;

namespace EFCoreApp
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() { }

        public MyDBContext(DbContextOptions<MyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
