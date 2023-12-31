﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieShop;

#nullable disable

namespace MovieShop.Migrations
{
    [DbContext(typeof(MovieShopDBContext))]
    [Migration("20230613015107_add-data-to-db")]
    partial class adddatatodb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MovieShop.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("DoB")
                        .HasColumnType("Date")
                        .HasColumnName("BirthDate");

                    b.Property<string>("FirstName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LastName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("PhoneNumber")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Ismailia",
                            DoB = new DateTime(1999, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Karim",
                            LastName = "Alaa",
                            PhoneNumber = 1234567891
                        },
                        new
                        {
                            Id = 2,
                            Address = "Ismailia",
                            DoB = new DateTime(2002, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ahmed",
                            LastName = "Alaa"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Ismailia",
                            FirstName = "Heba",
                            LastName = "Mohamed"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Portsaid",
                            DoB = new DateTime(1999, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Nada",
                            LastName = "Ahmed",
                            PhoneNumber = 123456789
                        },
                        new
                        {
                            Id = 5,
                            Address = "Suez",
                            DoB = new DateTime(1998, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Hussein",
                            LastName = "Alaa"
                        });
                });

            modelBuilder.Entity("MovieShop.Models.Customer_Movie", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("MovueId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateRented")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 6, 13, 4, 51, 7, 61, DateTimeKind.Local).AddTicks(4299))
                        .HasColumnName("Date_Rented");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Due_Date");

                    b.HasKey("CustomerId", "MovueId");

                    b.HasIndex("MovueId");

                    b.ToTable("Customers_Movies");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            MovueId = 1,
                            DueDate = new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 2,
                            MovueId = 2,
                            DueDate = new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 1,
                            MovueId = 5,
                            DueDate = new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 5,
                            MovueId = 6,
                            DueDate = new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 3,
                            MovueId = 4,
                            DueDate = new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 4,
                            MovueId = 1,
                            DateRented = new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 4,
                            MovueId = 9,
                            DueDate = new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 1,
                            MovueId = 3,
                            DueDate = new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MovieShop.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Duration")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int?>("ProducerId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<decimal?>("Rating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("ProducerId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Duration = 3,
                            ProducerId = 4,
                            Rating = 5m,
                            Title = "Avengers: Infinity War"
                        },
                        new
                        {
                            Id = 2,
                            Duration = 3,
                            ProducerId = 4,
                            Rating = 4.7m,
                            Title = "Avengers: End Game"
                        },
                        new
                        {
                            Id = 3,
                            Duration = 3,
                            ProducerId = 4,
                            Rating = 4.2m,
                            Title = "Enternals"
                        },
                        new
                        {
                            Id = 4,
                            Duration = 2,
                            ProducerId = 1,
                            Rating = 4.3m,
                            Title = "Hotel Transylvania"
                        },
                        new
                        {
                            Id = 5,
                            Duration = 3,
                            ProducerId = 4,
                            Rating = 4.9m,
                            Title = "Spider-Man: No Way Home"
                        },
                        new
                        {
                            Id = 6,
                            Duration = 2,
                            ProducerId = 1,
                            Rating = 4m,
                            Title = "Open Season"
                        },
                        new
                        {
                            Id = 7,
                            Duration = 2,
                            ProducerId = 1,
                            Rating = 3m,
                            Title = "The Smurfs"
                        },
                        new
                        {
                            Id = 8,
                            Duration = 2,
                            ProducerId = 3,
                            Rating = 4.5m,
                            Title = "Ice Age"
                        },
                        new
                        {
                            Id = 9,
                            Duration = 2,
                            ProducerId = 3,
                            Rating = 4.2m,
                            Title = "Night at the Museum"
                        },
                        new
                        {
                            Id = 10,
                            Duration = 2,
                            ProducerId = 3,
                            Rating = 0m,
                            Title = "Home Alone"
                        },
                        new
                        {
                            Id = 11,
                            Duration = 2,
                            ProducerId = 2,
                            Rating = 3.8m,
                            Title = "The Lion King"
                        },
                        new
                        {
                            Id = 12,
                            Duration = 3,
                            ProducerId = 2,
                            Rating = 4.5m,
                            Title = "Alaadin"
                        });
                });

            modelBuilder.Entity("MovieShop.Models.Producer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CompanyName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Country")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Producers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyName = "Sony Colomia",
                            Country = "USA"
                        },
                        new
                        {
                            Id = 2,
                            CompanyName = "Disney Pixar",
                            Country = "USA"
                        },
                        new
                        {
                            Id = 3,
                            CompanyName = "Fox 20th Century",
                            Country = "USA"
                        },
                        new
                        {
                            Id = 4,
                            CompanyName = "Marvel Studios",
                            Country = "USA"
                        });
                });

            modelBuilder.Entity("MovieShop.Models.Customer_Movie", b =>
                {
                    b.HasOne("MovieShop.Models.Customer", "Customer")
                        .WithMany("Customer_Movies")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieShop.Models.Movie", "Movie")
                        .WithMany("Customer_Movies")
                        .HasForeignKey("MovueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MovieShop.Models.Movie", b =>
                {
                    b.HasOne("MovieShop.Models.Producer", "Producer")
                        .WithMany("Movies")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("MovieShop.Models.Customer", b =>
                {
                    b.Navigation("Customer_Movies");
                });

            modelBuilder.Entity("MovieShop.Models.Movie", b =>
                {
                    b.Navigation("Customer_Movies");
                });

            modelBuilder.Entity("MovieShop.Models.Producer", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
