using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFavoriteBooks.Migrations
{
    public partial class UpdatingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "FirstName",
                value: "Robert C.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "FirstName",
                value: "Robert");
        }
    }
}
