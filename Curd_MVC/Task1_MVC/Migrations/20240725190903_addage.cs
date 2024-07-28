using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task1_MVC.Migrations
{
    /// <inheritdoc />
    public partial class addage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "adress",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "adress",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "age",
                table: "Students");
        }
    }
}
