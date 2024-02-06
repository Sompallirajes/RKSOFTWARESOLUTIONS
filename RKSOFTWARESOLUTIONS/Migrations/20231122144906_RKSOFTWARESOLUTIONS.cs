using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RKSOFTWARESOLUTIONS.Migrations
{
    /// <inheritdoc />
    public partial class RKSOFTWARESOLUTIONS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RegistrationForm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NewUserName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NewPassword = table.Column<int>(type: "int", nullable: true),
                    ConfirmPassword = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RKSolutions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Job = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Salary = table.Column<int>(type: "int", nullable: true),
                    Deptno = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "RegistrationForm");

            migrationBuilder.DropTable(
                name: "RKSolutions");
        }
    }
}
