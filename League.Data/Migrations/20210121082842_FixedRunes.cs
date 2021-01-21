using Microsoft.EntityFrameworkCore.Migrations;

namespace League.Data.Migrations
{
    public partial class FixedRunes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RiotId",
                table: "RunePaths",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Rune",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RiotId",
                table: "Rune",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rune_ImageId",
                table: "Rune",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rune_Images_ImageId",
                table: "Rune",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rune_Images_ImageId",
                table: "Rune");

            migrationBuilder.DropIndex(
                name: "IX_Rune_ImageId",
                table: "Rune");

            migrationBuilder.DropColumn(
                name: "RiotId",
                table: "RunePaths");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Rune");

            migrationBuilder.DropColumn(
                name: "RiotId",
                table: "Rune");
        }
    }
}
