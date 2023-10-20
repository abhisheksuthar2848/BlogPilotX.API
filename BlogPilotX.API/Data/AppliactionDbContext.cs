using BlogPilotX.API.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlogPilotX.API.Data
{
    public class AppliactionDbContext : DbContext
    {
        public AppliactionDbContext(DbContextOptions Options):base(Options)
        {
            
        }

        public DbSet<BlogPost> blogPosts { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}
