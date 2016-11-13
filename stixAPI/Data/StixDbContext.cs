namespace stixAPI.Data
{
	using Microsoft.EntityFrameworkCore;
	using stixAPI.Models;

	public class StixDbContext : DbContext
	{
		public StixDbContext(DbContextOptions<StixDbContext> options) : base(options)
		{ }

		public DbSet<Stig> Stig { get; set; }
	}
}
