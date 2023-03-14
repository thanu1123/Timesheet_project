using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimesheetPoject.Migrations
{
    /// <inheritdoc />
    public partial class emp1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Conformpassword",
                table: "Register",
                newName: "Confirmpassword");

            migrationBuilder.RenameColumn(
                name: "Conformpassword",
                table: "Login",
                newName: "Confirmpassword");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Confirmpassword",
                table: "Register",
                newName: "Conformpassword");

            migrationBuilder.RenameColumn(
                name: "Confirmpassword",
                table: "Login",
                newName: "Conformpassword");
        }
    }
}
