using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestingApp.Migrations
{
    public partial class added2entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Planning",
                columns: new[] { "Id", "Hours", "Week" },
                values: new object[] { 1, 40, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Planning",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
