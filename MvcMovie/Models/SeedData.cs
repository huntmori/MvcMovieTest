using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                //Look for any Movies
                if (context.Movie.Any())
                {
                    return; //DB has ben seeded
                }

                context.Movie.AddRange(
                    new Movie { Title="When Harry Met Sally",
                                ReleaseDate=DateTime.Parse("1989-1-11"),
                                Genre="Romantice Comedy",
                                Price=7.99M},
                    new Movie { Title="GhostBusters",
                                ReleaseDate=DateTime.Parse("1984-3-13"),
                                Genre="Comedy",
                                Price=8.99M},
                    new Movie{  Title="GhostBusters 2",
                                ReleaseDate = DateTime.Parse("1986-2-23"),
                                Genre = "Comedy",
                                Price = 9.99M},
                    new Movie { Title = "Rio Bravo",
                                ReleaseDate = DateTime.Parse("1959-4-15"),
                                Genre="Western",
                                Price=3.99M}
                );
                context.SaveChanges();
            }
        }
    }
}
