namespace stix.Controllers
{
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using Microsoft.AspNetCore.Mvc;
	using stixAPI.Models;
	using stixAPI.Data;
	using Microsoft.EntityFrameworkCore;

	public class StixController : Controller
	{
		private readonly StixDbContext context;

		public StixController(StixDbContext context)
		{
			this.context = context;
		}

		public async Task<IActionResult> Index()
		{
			return this.View(await this.context.Stig.ToListAsync());
		}
	}
}
