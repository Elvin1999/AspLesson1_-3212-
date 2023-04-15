using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;

namespace WebApplication1.Models
{
    public class SchoolDbContext:DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> contextOptions)
            :base(contextOptions)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
