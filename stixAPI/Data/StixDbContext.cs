namespace stixAPI.Models
{
    using Microsoft.EntityFrameworkCore;

    public class StixDbContext : DbContext
    {
        public StixDbContext(DbContextOptions<StixDbContext> options) : base(options)
        { }

        public DbSet<Stig> Stig { get; set; }
    }
}
