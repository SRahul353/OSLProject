using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OSLProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class post4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReplyModel_QAModels_QAModelId",
                table: "ReplyModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReplyModel",
                table: "ReplyModel");

            migrationBuilder.RenameTable(
                name: "ReplyModel",
                newName: "ReplyModels");

            migrationBuilder.RenameIndex(
                name: "IX_ReplyModel_QAModelId",
                table: "ReplyModels",
                newName: "IX_ReplyModels_QAModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReplyModels",
                table: "ReplyModels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReplyModels_QAModels_QAModelId",
                table: "ReplyModels",
                column: "QAModelId",
                principalTable: "QAModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReplyModels_QAModels_QAModelId",
                table: "ReplyModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReplyModels",
                table: "ReplyModels");

            migrationBuilder.RenameTable(
                name: "ReplyModels",
                newName: "ReplyModel");

            migrationBuilder.RenameIndex(
                name: "IX_ReplyModels_QAModelId",
                table: "ReplyModel",
                newName: "IX_ReplyModel_QAModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReplyModel",
                table: "ReplyModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReplyModel_QAModels_QAModelId",
                table: "ReplyModel",
                column: "QAModelId",
                principalTable: "QAModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
