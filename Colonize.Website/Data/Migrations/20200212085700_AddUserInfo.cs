using Microsoft.EntityFrameworkCore.Migrations;

namespace Colonize.Website.Data.Migrations
{
    public partial class AddUserInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "7476269c-a0ac-4ee2-b880-8d58615b5347", "0f54cd3a-de7c-4286-bcaa-35d8e6c7a7cc", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "7191c884-530b-49fd-8bec-0112186d69a0", "JOHN.DOE@NOMAIL.COM", "JOHN.DOE@NOMAIL.COM", "AQAAAAEAACcQAAAAEGNUpB4P2u9IonHHJ0a5EYjNMqqx5XhvImY1p9tvaF5jpuAloqi0/2vYFjwnHUE3Wg==" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "7476269c-a0ac-4ee2-b880-8d58615b5347" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "7476269c-a0ac-4ee2-b880-8d58615b5347" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7476269c-a0ac-4ee2-b880-8d58615b5347");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8df6674e-230b-471a-8c71-fd691469aa0d", "ce946b3f-fe44-4e68-9876-748930208730", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "1e6e26be-919e-45d2-bec2-dd3010cb173e", "john.doe@nomail.com", null, "AQAAAAEAACcQAAAAECU1/UoY7nIfCsibNd2aAKjK2C5O0gG8+O+rvrC0ZFPQjSzXsRjRVF0pNGMYyLP6uQ==" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "8df6674e-230b-471a-8c71-fd691469aa0d" });
        }
    }
}
