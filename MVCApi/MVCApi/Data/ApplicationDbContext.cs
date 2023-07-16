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
        
        public DbSet<Student> students { get; set; }
        public DbSet<Campus> campuses { get; set; }
        public DbSet<Club> clubs { get; set; }
        public DbSet<Major> majors { get; set; }
        

    }
}
