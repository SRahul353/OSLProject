using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OSLProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class qa1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "QAModels",
                newName: "User");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "User",
                table: "QAModels",
                newName: "Title");
        }
    }
}
