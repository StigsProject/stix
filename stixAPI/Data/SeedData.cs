namespace stixAPI.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Models;
    using System;
    using System.Linq;

    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new StixDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<StixDbContext>>()))
            {
                // Look for any Stig.
                if (context.Stig.Any())
                {
                    // DB has been seeded.
                    return;
                }

                context.Stig.Add(
                    new Stig
                    {
                        Title = "TestStig",
                        Description = "This is a test!",
                        Location = "Potsdam"
                    });
                context.SaveChanges();
            }
        }
    }
}
