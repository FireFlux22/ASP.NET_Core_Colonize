using Microsoft.EntityFrameworkCore.Migrations;

namespace Colonize.Website.Data.Migrations
{
    public partial class AddSeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "648a4deb-de5d-4b07-a1c9-058f57a2d4f1", "4f7827a3-c057-472f-b0a3-9cdc5e349d67", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "59d61a9a-7263-44a8-8d6e-5537d4bdd0ef", "AQAAAAEAACcQAAAAEDg/r3O8FA5Xf3p4XpdxPZooMH5MpDKdVnDIXUPCrc05Fm4QtWzCTq3va4EsKAy3PA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "648a4deb-de5d-4b07-a1c9-058f57a2d4f1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "718b8cf3-14ba-4493-8f1a-9c06d00ce07a", "AQAAAAEAACcQAAAAEPQIAvOrc8s9h7c12pjX1z0Ar/CSBoXEN1O66kOEHfnv3KdzG2zD0wscy2Mb21XGSw==" });
        }
    }
}
