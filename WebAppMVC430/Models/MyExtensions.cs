using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace WebAppMVC430.Models
{
    public static class MyExtensions
    {
        public static void Seed(this ModelBuilder model)
        {
            model.Entity<Country>().HasData(
                new Country() { Id = 1, Name = "India", Code = "IN" },
                new Country() { Id = 2, Name = "United State of America", Code = "USA" },
                new Country() { Id = 3, Name = "Canada", Code = "CA" }


                );
        }
    }
}
