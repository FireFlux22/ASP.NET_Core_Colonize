using Microsoft.EntityFrameworkCore.Migrations;

namespace Colonize.Website.Data.Migrations
{
    public partial class AddManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "718b8cf3-14ba-4493-8f1a-9c06d00ce07a", "AQAAAAEAACcQAAAAEPQIAvOrc8s9h7c12pjX1z0Ar/CSBoXEN1O66kOEHfnv3KdzG2zD0wscy2Mb21XGSw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f03412e5-b058-4e8f-b8cc-0bf6be4ec33d", "AQAAAAEAACcQAAAAEAj8PuPPtNa04wr1ahApISnsDB+wVBXEAOL6M/iCchb205s34CA14oRShz1mB0NY9A==" });
        }
    }
}
