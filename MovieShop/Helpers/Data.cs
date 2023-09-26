using MovieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop
{
    public class Data
    {
        #region Customers
        public static List<Customer> customers = new(){
                new() {
                    Id = 1,
                    FirstName = "Karim",
                    LastName = "Alaa",
                    Address = "Ismailia",
                    DoB = new(1999, 5, 19),
                    PhoneNumber = 01234567891
                },
                new() {
                    Id = 2,
                    FirstName = "Ahmed",
                    LastName = "Alaa",
                    Address = "Ismailia",
                    DoB = new(2002, 3, 16),
                },
                new() {
                    Id = 3,
                    FirstName = "Heba",
                    LastName = "Mohamed",
                    Address = "Ismailia",
                },
                new() {
                    Id = 4,
                    FirstName = "Nada",
                    LastName = "Ahmed",
                    Address = "Portsaid",
                    DoB = new(1999, 4, 11),
                    PhoneNumber = 0123456789
                },
                new() {
                    Id = 5,
                    FirstName = "Hussein",
                    LastName = "Alaa",
                    Address = "Suez",
                    DoB = new(1998, 5, 30),
                }
            };
        #endregion

        #region Producers
        public static List<Producer> producers = new()
            {
                new() {
                    Id = 1,
                    CompanyName = "Sony Colomia",
                    Country = "USA"
                },
                new() {
                    Id = 2,
                    CompanyName = "Disney Pixar",
                    Country = "USA"
                },
                new() {
                    Id = 3,
                    CompanyName = "Fox 20th Century",
                    Country = "USA"
                },
                new() {
                    Id = 4,
                    CompanyName = "Marvel Studios",
                    Country = "USA"
                }
            };
        #endregion

        #region Movie
        public static List<Movie> movies = new()
            {
                new()
                {
                    Id = 1,
                    Title = "Avengers: Infinity War",
                    Duration = 3,
                    Rating = 5,
                    ProducerId = 4,
                },
                new()
                {
                    Id = 2,
                    Title = "Avengers: End Game",
                    Duration = 3,
                    Rating = (decimal) 4.7,
                    ProducerId= 4,
                },
                 new()
                {
                    Id = 3,
                    Title = "Enternals",
                    Duration = 3,
                    Rating = (decimal) 4.2,
                    ProducerId= 4,
                },
                new()
                {
                    Id = 4,
                    Title = "Hotel Transylvania",
                    Duration = 2,
                    Rating = (decimal) 4.3,
                    ProducerId= 1,
                },
                new()
                {
                    Id = 5,
                    Title = "Spider-Man: No Way Home",
                    Duration = 3,
                    Rating = (decimal) 4.9,
                    ProducerId= 4,
                },
                new()
                {
                    Id = 6,
                    Title = "Open Season",
                    Duration = 2,
                    Rating = 4,
                    ProducerId= 1,
                },
                new()
                {
                    Id = 7,
                    Title = "The Smurfs",
                    Duration = 2,
                    Rating = 3,
                    ProducerId= 1,
                },
                new()
                {
                    Id = 8,
                    Title = "Ice Age",
                    Duration = 2,
                    Rating = (decimal) 4.5,
                    ProducerId= 3,
                },
                new()
                {
                    Id = 9,
                    Title = "Night at the Museum",
                    Duration = 2,
                    Rating = (decimal) 4.2,
                    ProducerId= 3,
                },
                new()
                {
                    Id = 10,
                    Title = "Home Alone",
                    Duration = 2,
                    ProducerId= 3,
                },
                new()
                {
                    Id = 11,
                    Title = "The Lion King",
                    Duration = 2,
                    Rating = (decimal) 3.8,
                    ProducerId= 2,
                },
                new()
                {
                    Id = 12,
                    Title = "Alaadin",
                    Duration = 3,
                    Rating = (decimal) 4.5,
                    ProducerId= 2,
                },
            };
        #endregion

        #region CustomerMovie
        public static List<Customer_Movie> rentals = new List<Customer_Movie>() {
                new()
                {
                    CustomerId = 1,
                    MovueId = 1,
                    DueDate = new DateTime(DateTime.Now.Year, 6, 19)
                },
                new()
                {
                    CustomerId = 2,
                    MovueId = 2,
                    DueDate = new DateTime(DateTime.Now.Year, 6, 17)
                },
                new()
                {
                    CustomerId = 1,
                    MovueId = 5,
                    DueDate = new DateTime(DateTime.Now.Year, 6, 19)
                },
                new()
                {
                    CustomerId = 5,
                    MovueId = 6,
                    DueDate = new DateTime(DateTime.Now.Year, 6, 19)
                },
                new()
                {
                    CustomerId = 3,
                    MovueId = 4,
                    DueDate = new DateTime(DateTime.Now.Year, 6, 19)
                },
                new()
                {
                    CustomerId = 4,
                    MovueId = 1,
                    DateRented = new DateTime(DateTime.Now.Year, 6, 25),
                    DueDate = new DateTime(DateTime.Now.Year, 6, 29)
                },
                new()
                {
                    CustomerId = 4,
                    MovueId = 9,
                    DueDate = new DateTime(DateTime.Now.Year, 6, 19)
                },
                new()
                {
                    CustomerId = 1,
                    MovueId = 3,
                    DueDate = new DateTime(DateTime.Now.Year, 6, 19)
                },
            };
        #endregion
    }
}
