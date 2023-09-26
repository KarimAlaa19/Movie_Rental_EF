using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieShop.Migrations
{
    /// <inheritdoc />
    public partial class adddatatodb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_Rented",
                table: "Customers_Movies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 6, 13, 4, 51, 7, 61, DateTimeKind.Local).AddTicks(4299),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 6, 13, 4, 50, 45, 78, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "BirthDate", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Ismailia", new DateTime(1999, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karim", "Alaa", 1234567891 },
                    { 2, "Ismailia", new DateTime(2002, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahmed", "Alaa", null },
                    { 3, "Ismailia", null, "Heba", "Mohamed", null },
                    { 4, "Portsaid", new DateTime(1999, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nada", "Ahmed", 123456789 },
                    { 5, "Suez", new DateTime(1998, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hussein", "Alaa", null }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "CompanyName", "Country" },
                values: new object[,]
                {
                    { 1, "Sony Colomia", "USA" },
                    { 2, "Disney Pixar", "USA" },
                    { 3, "Fox 20th Century", "USA" },
                    { 4, "Marvel Studios", "USA" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Duration", "ProducerId", "Rating", "Title" },
                values: new object[,]
                {
                    { 1, 3, 4, 5m, "Avengers: Infinity War" },
                    { 2, 3, 4, 4.7m, "Avengers: End Game" },
                    { 3, 3, 4, 4.2m, "Enternals" },
                    { 4, 2, 1, 4.3m, "Hotel Transylvania" },
                    { 5, 3, 4, 4.9m, "Spider-Man: No Way Home" },
                    { 6, 2, 1, 4m, "Open Season" },
                    { 7, 2, 1, 3m, "The Smurfs" },
                    { 8, 2, 3, 4.5m, "Ice Age" },
                    { 9, 2, 3, 4.2m, "Night at the Museum" },
                    { 10, 2, 3, 0m, "Home Alone" },
                    { 11, 2, 2, 3.8m, "The Lion King" },
                    { 12, 3, 2, 4.5m, "Alaadin" }
                });

            migrationBuilder.InsertData(
                table: "Customers_Movies",
                columns: new[] { "CustomerId", "MovueId", "Due_Date" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 3, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 5, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 4, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Customers_Movies",
                columns: new[] { "CustomerId", "MovueId", "Date_Rented", "Due_Date" },
                values: new object[] { 4, 1, new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Customers_Movies",
                columns: new[] { "CustomerId", "MovueId", "Due_Date" },
                values: new object[,]
                {
                    { 4, 9, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 6, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers_Movies",
                keyColumns: new[] { "CustomerId", "MovueId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Customers_Movies",
                keyColumns: new[] { "CustomerId", "MovueId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Customers_Movies",
                keyColumns: new[] { "CustomerId", "MovueId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "Customers_Movies",
                keyColumns: new[] { "CustomerId", "MovueId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Customers_Movies",
                keyColumns: new[] { "CustomerId", "MovueId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "Customers_Movies",
                keyColumns: new[] { "CustomerId", "MovueId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "Customers_Movies",
                keyColumns: new[] { "CustomerId", "MovueId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "Customers_Movies",
                keyColumns: new[] { "CustomerId", "MovueId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_Rented",
                table: "Customers_Movies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 6, 13, 4, 50, 45, 78, DateTimeKind.Local).AddTicks(401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 6, 13, 4, 51, 7, 61, DateTimeKind.Local).AddTicks(4299));
        }
    }
}
