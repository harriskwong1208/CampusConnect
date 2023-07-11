using Microsoft.EntityFrameworkCore;
using MVCApi.Models;

namespace MVCApi.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Category> categories { get; set; }
    }
}
