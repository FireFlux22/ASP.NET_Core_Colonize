using Microsoft.EntityFrameworkCore.Migrations;

namespace Colonize.Website.Data.Migrations
{
    public partial class SeedDatabaseWithShips : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ship",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "PassengerCapacity" },
                values: new object[] { 1, "Lorem ipsum dolor", "https://via.placeholder.com/1280x280.png?text=Hero+1", "Moonshot", 200 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
