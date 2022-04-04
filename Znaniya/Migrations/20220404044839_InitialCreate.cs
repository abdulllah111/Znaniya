using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Znaniya.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubText",
                table: "Shelfs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubText",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubText",
                table: "Chapters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubText",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "5e6c0a70-6b8d-46e7-a096-1379d90e36a3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "20e3d17e-2cd9-4059-b127-24fcacb6b585", "AQAAAAEAACcQAAAAEEjJXdy8Lj4czv5UeisMVhv9H8fdrFwfhpsdQcVJKTastAdcjHTT8cw1wMIOQKjCEg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubText",
                table: "Shelfs");

            migrationBuilder.DropColumn(
                name: "SubText",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SubText",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "SubText",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "f04c40b0-3543-496d-84aa-8c1109542087");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "977a049c-36a3-427d-a957-e8087a008ee1", "AQAAAAEAACcQAAAAEMDIAPw1TIbVtC3vtdrKJ7a1xGclL8+L+jFFpu1kxFIMU9KjcX0HBQl705C0BYLUQA==" });
        }
    }
}
