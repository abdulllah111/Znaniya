using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Znaniya.Migrations
{
    public partial class _initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "4aa72f06-5ab3-4c9e-9525-02ca881dafc5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d0eb4403-266d-498e-a6ef-a437bcee1fc9", "AQAAAAEAACcQAAAAEP3qQ0Qa7zxdqhysQeIlrPBGiheqmM1bcm0JbY06w6vvopqabeDkEuNa2mpApVAW+Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "ef1ec1f0-e5ed-4caf-b18d-8947a7e1fae5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1f962e67-d2f0-4933-b22a-3567786797db", "AQAAAAEAACcQAAAAEHbQVhJi5zOKBrbFKsWmpwtoCVG6g3nVYHuUEKRAeLulCUe5qBbjPa6gahgXbhUwuQ==" });
        }
    }
}
