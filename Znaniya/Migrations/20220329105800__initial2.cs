using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Znaniya.Migrations
{
    public partial class _initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MetaDescription",
                table: "Shelfs");

            migrationBuilder.DropColumn(
                name: "MetaKeywords",
                table: "Shelfs");

            migrationBuilder.DropColumn(
                name: "MetaTitle",
                table: "Shelfs");

            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "Shelfs");

            migrationBuilder.DropColumn(
                name: "TitleImagePath",
                table: "Shelfs");

            migrationBuilder.DropColumn(
                name: "MetaDescription",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "MetaKeywords",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "MetaTitle",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "TitleImagePath",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "MetaDescription",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "MetaKeywords",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "MetaTitle",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "TitleImagePath",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "MetaDescription",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "MetaKeywords",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "MetaTitle",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "TitleImagePath",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MetaDescription",
                table: "Shelfs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaKeywords",
                table: "Shelfs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaTitle",
                table: "Shelfs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "Shelfs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleImagePath",
                table: "Shelfs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaDescription",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaKeywords",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaTitle",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleImagePath",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaDescription",
                table: "Chapters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaKeywords",
                table: "Chapters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaTitle",
                table: "Chapters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "Chapters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleImagePath",
                table: "Chapters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaDescription",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaKeywords",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaTitle",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleImagePath",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "086665da-f39d-4355-96f6-561c1efa6985");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "97625139-e170-47b7-a800-d5e42c2b9619", "AQAAAAEAACcQAAAAELSaUfGFV8VVaH3aI2apPR6JScDtDh2kMAM0HOv3Wwq8CwxUdrFzRzZIXt2qvrzvIw==" });
        }
    }
}
