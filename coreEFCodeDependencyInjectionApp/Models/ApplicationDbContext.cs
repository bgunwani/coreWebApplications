using Microsoft.EntityFrameworkCore;

namespace coreEFCodeDependencyInjectionApp.Models
{
    public class ApplicationDbContext: DbContext
    {

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-Q8KMI7N;Database=Trialdb;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
