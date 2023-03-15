using Microsoft.EntityFrameworkCore;

namespace SkolmatenNyNy.Models
{
    public class MatContext : DbContext
    {
        public DbSet<Mat> Ratter { get; set; }
        public MatContext() 
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=matData.db");
        }
    }
}
