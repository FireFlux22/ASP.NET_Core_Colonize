using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Colonize.Website.Data.Migrations
{
    public partial class AddVoyageIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VoyageIdentityUser",
                columns: table => new
                {
                    VoyageId = table.Column<int>(nullable: false),
                    IdentityUserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoyageIdentityUser", x => new { x.VoyageId, x.IdentityUserId });
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f03412e5-b058-4e8f-b8cc-0bf6be4ec33d", "AQAAAAEAACcQAAAAEAj8PuPPtNa04wr1ahApISnsDB+wVBXEAOL6M/iCchb205s34CA14oRShz1mB0NY9A==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VoyageIdentityUser");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "26b513c4-a419-41cb-ac7a-dad48de259eb", "AQAAAAEAACcQAAAAEK1LGhHFw/Xuds0mpOTQpUZiDGgtXcIekBBrXMf1UXrY/5V3lnGMDy103sS8yYQfng==" });
        }
    }
}
