namespace stixAPI.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Models;

    [Route("api/[controller]")]
    public class StigController : Controller
    {
        private StixDbContext context;

        public StigController(StixDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Stig>> Get()
        {
            return await this.context.Stig.ToListAsync();
        }
    }
}