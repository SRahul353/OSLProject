using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OSLProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class post3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReplyModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QAModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReplyModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReplyModel_QAModels_QAModelId",
                        column: x => x.QAModelId,
                        principalTable: "QAModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReplyModel_QAModelId",
                table: "ReplyModel",
                column: "QAModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReplyModel");
        }
    }
}
