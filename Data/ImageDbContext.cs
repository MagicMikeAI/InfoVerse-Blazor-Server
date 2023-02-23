using InfoVerse.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoVerse.Data
{
    public class ImageDbContext : DbContext
    {
        public ImageDbContext(DbContextOptions<ImageDbContext> options) : base(options)
        {
        }

        public DbSet<ImageModel> Images { get; set; }
    }

}
