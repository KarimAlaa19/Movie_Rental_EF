using Microsoft.EntityFrameworkCore;
using MovieShop.Models;

namespace MovieShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieShopDBContext db = new MovieShopDBContext();

            ////top 3 rented movies
            //var q1 = db.Customers_Movies
            //    .Include(m => m.Movie)
            //    .GroupBy(m => m.Movie.Title)
            //    .Select(m => new { MovieName = m.Key, Rentals = m.Count() })
            //    .OrderByDescending(m => m.Rentals)
            //    .Take(3);

            //foreach (var m in q1)
            //{
            //    Console.WriteLine(m);
            //}

            ////producer with most movies
            //var q2 = db.Producers.OrderByDescending(p => p.Movies.Count).Take(1).Include(p => p.Movies);

            //foreach (var p in q2)
            //{
            //    Console.WriteLine($"Producer: {p.CompanyName}, Movies Count: {p.Movies.Count}");
            //    Console.WriteLine("Movies: ");
            //    foreach (var m in p.Movies)
            //    {
            //        Console.WriteLine(m.Title);
            //    }
            //}

            ////customers ordered by rental
            //var q3 = db.Customers
            //    .OrderBy(c => c.Customer_Movies.Count)
            //    .Select(c => new { Name = (c.FirstName + " " + c.LastName), NoRentals = c.Customer_Movies.Count});

            //foreach (var item in q3)
            //{
            //    Console.WriteLine(item);
            //}

            //var q4 = db.Customers_Movies
            //    .Include(cm => cm.Customer)
            //    .Include(cm => cm.Movie)
            //        .ThenInclude(m => m.Producer)
            //    .Select(cm => new
            //    {
            //        CustomerName = (cm.Customer.FirstName + " " + cm.Customer.LastName),
            //        MovieName = cm.Movie.Title,
            //        Producer = cm.Movie.Producer,
            //        cm.DateRented,
            //        OverDueRemainingDays = (cm.DueDate - cm.DateRented).Value.Days
            //    });


            //foreach(var r in q4)
            //{
            //    Console.WriteLine(r);
            //}


            /////Query 5
            ///
            ////first solution
            var q5 = db.Customers_Movies
                .Include(cm => cm.Customer)
                .Include(cm => cm.Movie)
                .Where(cm => cm.DueDate < DateTime.Now)
                .Select(cm => new
                {
                    CustomerName = (cm.Customer.FirstName + " " + cm.Customer.LastName),
                    MovieName = cm.Movie.Title,
                    cm.DateRented,
                    OverDueRemainingDays = (DateTime.Now - cm.DueDate.Value).Days
                })
                .ToList()
                .OrderByDescending(cm => cm.OverDueRemainingDays);



            foreach (var r in q5)
            {
                Console.WriteLine(r);
            }
        }
    }
}