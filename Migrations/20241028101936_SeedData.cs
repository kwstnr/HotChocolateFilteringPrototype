using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Prototype.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("040b979f-204c-4cdd-8d99-20d77ea3c0dd"), "Author 1" },
                    { new Guid("a48658ba-e41c-4634-9846-89df0fd6a953"), "Author 2" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Title" },
                values: new object[,]
                {
                    { new Guid("461d585b-248e-41a7-b154-1ddd5addda4a"), new Guid("a48658ba-e41c-4634-9846-89df0fd6a953"), "Book 2" },
                    { new Guid("b56a4853-86eb-4ae8-b0b0-fef35a2d870f"), new Guid("040b979f-204c-4cdd-8d99-20d77ea3c0dd"), "Book 1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("461d585b-248e-41a7-b154-1ddd5addda4a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b56a4853-86eb-4ae8-b0b0-fef35a2d870f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("040b979f-204c-4cdd-8d99-20d77ea3c0dd"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a48658ba-e41c-4634-9846-89df0fd6a953"));
        }
    }
}
