using FitLife.Models;
using Microsoft.EntityFrameworkCore;

namespace FitLife.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        
        public DbSet<DietLog> DietLogTable { get; set; }
        public DbSet<HabitLog> HabitLogTable { get; set; }
        public DbSet<WorkOutLog> WorkOutLogTable { get; set; }
    }
}
