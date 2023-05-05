using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using TestingApp.Data;

namespace TestingApp.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new TestingAppContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<TestingAppContext>>()))
        {
            // Look for any movies.
            if (context.Planning.Any())
            {
                return;   // DB has been seeded
            }
            context.Planning.AddRange(
                
                new Planning
                {
                    Id = 1,
                    Week = 23,
                    Hours = 50
                },
                new Planning
                {
                    Id = 2,
                    Week = 2,
                    Hours = 5
                },
                new Planning
                {
                    Id = 3,
                    Week = 230,
                    Hours = 500
                }
            );
            context.SaveChanges();
        }
    }
}
