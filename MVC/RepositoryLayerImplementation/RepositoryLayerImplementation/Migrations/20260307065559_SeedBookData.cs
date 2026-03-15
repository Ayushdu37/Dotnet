using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RepositoryLayerImplementation.Migrations
{
    /// <inheritdoc />
    public partial class SeedBookData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "FullName", "Genre", "Price" },
                values: new object[,]
                {
                    { 1, "J.K Rowling", "Harry Potter", "Fantasy", 500f },
                    { 2, "James Clear", "Atomic Habits", "Self Help", 450f },
                    { 3, "Robert Kiyosaki", "Rich Dad Poor Dad", "Finance", 350f },
                    { 4, "Paulo Coelho", "The Alchemist", "Fiction", 300f },
                    { 5, "J.K Rowling", "Harry Potter", "Fantasy", 600f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
