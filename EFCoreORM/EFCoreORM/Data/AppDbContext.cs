using EFCoreORM.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreORM.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EFCoreORM;TrustServerCertificate=True;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
