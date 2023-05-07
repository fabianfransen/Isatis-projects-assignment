using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestingApp.Migrations
{
    public partial class LinkedProjectAndEmployeeToPlanning : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Planning",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Planning",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractHours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "ContractHours", "Name" },
                values: new object[] { 1, 40, "Kees" });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Project 1" });

            migrationBuilder.UpdateData(
                table: "Planning",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EmployeeId", "ProjectId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Planning_EmployeeId",
                table: "Planning",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Planning_ProjectId",
                table: "Planning",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Planning_Employee_EmployeeId",
                table: "Planning",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Planning_Project_ProjectId",
                table: "Planning",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planning_Employee_EmployeeId",
                table: "Planning");

            migrationBuilder.DropForeignKey(
                name: "FK_Planning_Project_ProjectId",
                table: "Planning");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Planning_EmployeeId",
                table: "Planning");

            migrationBuilder.DropIndex(
                name: "IX_Planning_ProjectId",
                table: "Planning");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Planning");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Planning");
        }
    }
}
