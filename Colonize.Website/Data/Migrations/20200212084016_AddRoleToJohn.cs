using Microsoft.EntityFrameworkCore.Migrations;

namespace Colonize.Website.Data.Migrations
{
    public partial class AddRoleToJohn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "648a4deb-de5d-4b07-a1c9-058f57a2d4f1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8df6674e-230b-471a-8c71-fd691469aa0d", "ce946b3f-fe44-4e68-9876-748930208730", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1e6e26be-919e-45d2-bec2-dd3010cb173e", "AQAAAAEAACcQAAAAECU1/UoY7nIfCsibNd2aAKjK2C5O0gG8+O+rvrC0ZFPQjSzXsRjRVF0pNGMYyLP6uQ==" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "8df6674e-230b-471a-8c71-fd691469aa0d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "8df6674e-230b-471a-8c71-fd691469aa0d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8df6674e-230b-471a-8c71-fd691469aa0d");

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
    }
}
