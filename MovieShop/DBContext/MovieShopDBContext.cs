using Microsoft.EntityFrameworkCore;
using MovieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop
{
    public class MovieShopDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseSqlServer(@"Server=.\SQLSERVER2022; Database=MovieShop; Trusted_Connection=True; Encrypt=False;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ////Setting Customer_Movie Configs
            modelBuilder.Entity<Customer_Movie>(cm =>
            {
                ////Adding Composite Primary Key to Customer_Movie Entity
                cm.HasKey(e => new { e.CustomerId, e.MovueId });
                cm.Property(p => p.DateRented).HasDefaultValue(DateTime.Now);
            });

            base.OnModelCreating(modelBuilder);

            #region Adding Data
            //modelBuilder.Entity<Movie>().HasData(Data.movies);
            //modelBuilder.Entity<Producer>().HasData(Data.producers);
            //modelBuilder.Entity<Customer>().HasData(Data.customers);
            //modelBuilder.Entity<Customer_Movie>().HasData(Data.rentals);
            #endregion

        }



        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Customer_Movie> Customers_Movies { get; set; }
    }
}
