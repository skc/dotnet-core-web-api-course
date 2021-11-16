using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Models.Book()
                    {
                        Title = "First Book Title",
                        Descrition = "This is my first book in the database",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biography",
                        Author = "Bill D. Killer",
                        CoverUrl = "http://....",
                        DateAdded = DateTime.Now.AddDays(-60)
                    },
                    new Models.Book()
                    {
                        Title = "Second Book Title",
                        Descrition = "This is my secon book in the database",
                        IsRead = false,
                        Genre = "Drama",
                        Author = "Bill Love",
                        CoverUrl = "http://....",
                        DateAdded = DateTime.Now
                    });
                    context.SaveChanges();
                }
            }

        }
    }
}
