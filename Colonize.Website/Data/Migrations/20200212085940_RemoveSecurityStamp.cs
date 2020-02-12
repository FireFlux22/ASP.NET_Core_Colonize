using Microsoft.EntityFrameworkCore.Migrations;

namespace Colonize.Website.Data.Migrations
{
    public partial class RemoveSecurityStamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "c8c55068-7d8f-4b4b-8722-25d2ad0e89b3", "171e0f82-5394-4db8-91c1-3ba44964f656", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b0048dc-6bd6-47a6-a081-6696814a5579", "AQAAAAEAACcQAAAAEPOLoZS+gXbgq9RE2RE12dI+yyWXlty8cZo9LpGQ4OVoY5elgHQwQ37ON1NtowXQnA==", "ddc6f919-b75d-4303-9c58-7ba0d0e48bcf" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "c8c55068-7d8f-4b4b-8722-25d2ad0e89b3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "c8c55068-7d8f-4b4b-8722-25d2ad0e89b3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8c55068-7d8f-4b4b-8722-25d2ad0e89b3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7476269c-a0ac-4ee2-b880-8d58615b5347", "0f54cd3a-de7c-4286-bcaa-35d8e6c7a7cc", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7191c884-530b-49fd-8bec-0112186d69a0", "AQAAAAEAACcQAAAAEGNUpB4P2u9IonHHJ0a5EYjNMqqx5XhvImY1p9tvaF5jpuAloqi0/2vYFjwnHUE3Wg==", "" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "7476269c-a0ac-4ee2-b880-8d58615b5347" });
        }
    }
}
