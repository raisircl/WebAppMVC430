using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMVC430.Migrations
{
    /// <inheritdoc />
    public partial class coverimagemig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoverImage",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverImage",
                table: "Departments");
        }
    }
}
