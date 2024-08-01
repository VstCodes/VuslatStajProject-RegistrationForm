using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VuslatProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "SelectedDepartmentId",
                table: "Visitors");

            migrationBuilder.AddColumn<string>(
                name: "Recipient",
                table: "Visitors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SelectedDepartment",
                table: "Visitors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Recipient",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "SelectedDepartment",
                table: "Visitors");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Visitors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SelectedDepartmentId",
                table: "Visitors",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
