namespace stixAPI.Controllers
{
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.EntityFrameworkCore;
	using stixAPI.Models;
	using stixAPI.Data;

	[Route("api/[controller]")]
	public class StigController : Controller
	{
		private readonly StixDbContext context;

		public StigController(StixDbContext context)
		{
			this.context = context;
		}

		[HttpGet]
		public async Task<IEnumerable<Stig>> Get()
		{
			return await this.context.Stig.ToListAsync();
		}
	}
}