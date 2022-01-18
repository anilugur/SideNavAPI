using Microsoft.EntityFrameworkCore;

namespace SideNavAPI.Data
{
    public class NavDBContext:DbContext
    {
        public NavDBContext(DbContextOptions<NavDBContext> options) : base(options)
        {
        }
        public DbSet<NavItemEntry> NavItemEntrySet { get; set; }
    }
}
