using CheesyApi.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Drawing;

namespace CheesyApi.Migrations
{
    public partial class SeedCheeses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cheese",
                columns: new[] { "Id", "Name", "PricePerKilogram", "Color" },
                values: new object[] { 
                    1, 
                    "LE GRUYÈRE AOP",
                    63.8M,
                    Color.FromArgb(249, 221, 141).ToArgb()
                });

            migrationBuilder.InsertData(
                table: "Cheese",
                columns: new[] { "Id", "Name", "PricePerKilogram", "Color" },
                values: new object[] {
                    2,
                    "MANCHEGO",
                    60.1M,
                    Color.FromArgb(239,209,164).ToArgb()
                });

            migrationBuilder.InsertData(
                table: "Cheese",
                columns: new[] { "Id", "Name", "PricePerKilogram", "Color" },
                values: new object[] {
                    3,
                    "AMERICAN CHEESE",
                    34.95M,
                    Color.FromArgb(254,188,47).ToArgb()
                });

            migrationBuilder.InsertData(
                table: "Cheese",
                columns: new[] { "Id", "Name", "PricePerKilogram", "Color" },
                values: new object[] {
                    4,
                    "CAMEMBERT",
                    28.35M,
                    Color.FromArgb(162,160,134).ToArgb()
                });

            migrationBuilder.InsertData(
                table: "Cheese",
                columns: new[] { "Id", "Name", "PricePerKilogram", "Color" },
                values: new object[] {
                    5,
                    "PARMESAN",
                    41.45M,
                    Color.FromArgb(251,217,178).ToArgb()
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
