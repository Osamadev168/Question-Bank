using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Testing_System.Migrations
{
    /// <inheritdoc />
    public partial class Newquestion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Options",
                table: "Questions",
                newName: "Option3");

            migrationBuilder.AddColumn<string>(
                name: "Option1",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Option2",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Option1",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Option2",
                table: "Questions");

            migrationBuilder.RenameColumn(
                name: "Option3",
                table: "Questions",
                newName: "Options");
        }
    }
}
