using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VuslatProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisitorSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisitorPhoneNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisitorEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SelectedDepartmentId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visitors");
        }
    }
}
