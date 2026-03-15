using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RepositoryLayerImplementation.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "FullName", "Genre", "Price" },
                values: new object[,]
                {
                    { 101, "J.K Rowling", "Harry Potter", "Fantasy", 500f },
                    { 102, "James Clear", "Atomic Habits", "Self Help", 450f },
                    { 103, "Robert Kiyosaki", "Rich Dad Poor Dad", "Finance", 350f },
                    { 104, "Paulo Coelho", "The Alchemist", "Fiction", 300f },
                    { 105, "J.K Rowling", "Harry Potter", "Fantasy", 600f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 105);

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
    }
}
