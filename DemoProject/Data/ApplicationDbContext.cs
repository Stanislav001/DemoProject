using DemoProject.Data.DataModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Author> Authors { get; set; }

        public DbSet<AuthorMovies> AuthorMovies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-4EJHC35;Database=MovieDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}