using Microsoft.EntityFrameworkCore.Migrations;

namespace Colonize.Website.Data.Migrations
{
    public partial class AddProductSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ArticleNumber = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    UrlSlug = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "26b513c4-a419-41cb-ac7a-dad48de259eb", "john.doe@nomail.com", true, false, null, "john.doe@nomail.com", null, "AQAAAAEAACcQAAAAEK1LGhHFw/Xuds0mpOTQpUZiDGgtXcIekBBrXMf1UXrY/5V3lnGMDy103sS8yYQfng==", "0707-12345", false, "", false, "john.doe@nomail.com" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "ArticleNumber", "Description", "ImageUrl", "Name", "Price", "UrlSlug" },
                values: new object[,]
                {
                    { 1, "COL-123-2568", "Lovely facehugger great quality family friendly buy now", "https://img.fruugo.com/product/4/36/95205364_max.jpg", "Facehugger Plushie", 29m, "facehugger-plushie" },
                    { 2, "COL-345-1234", "Not the acutal size of the spaceship", "https://i.pinimg.com/originals/bf/f9/2b/bff92b658e36100d1b57b94c18b5dd5f.jpg", "Moonshot model ship", 19m, "moonshot-model" }
                });

            migrationBuilder.UpdateData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://via.placeholder.com/480x360.png?text=Moonshot");

            migrationBuilder.UpdateData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://via.placeholder.com/480x360.png?text=Mars+Explorer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575");

            migrationBuilder.UpdateData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://via.placeholder.com/1280x280.png?text=Moonshot");

            migrationBuilder.UpdateData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://via.placeholder.com/1280x280.png?text=Mars+Explorer");
        }
    }
}
