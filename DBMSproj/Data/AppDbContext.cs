using DBMSproj.Components.Pages;
using Microsoft.EntityFrameworkCore;

namespace DBMSproj.Data 
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<BankDetails> BankDetails { get; set; }
    }
}
