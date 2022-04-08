using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Znaniya.Migrations
{
    public partial class fixChapter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ChapterId",
                table: "Chapters",
                newName: "ChapterID");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "92a4069b-b749-4f70-a840-a13a55a4b4a9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c9b98ec1-21db-4d04-9736-d871ef269995", "AQAAAAEAACcQAAAAENJ3U5b1a3eQepfEwwVZTTALh5A+wQAJTDvaLzTR2YTZ3qC8p4mQEXZXXjqqIblZRw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ChapterID",
                table: "Chapters",
                newName: "ChapterId");

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
    }
}
