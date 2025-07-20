using Microsoft.EntityFrameworkCore;
using task_in_setion.Models;

namespace task_in_setion.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Products> Products { get; set; }
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

    }
}
