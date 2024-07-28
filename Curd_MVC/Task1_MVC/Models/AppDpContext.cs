using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Task1_MVC.Models
{
    public class AppDbContext : DbContext
    {
       // public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SHREEN\\SHREENSQL;Database=StudentData;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True");
        }


         

    }

}
