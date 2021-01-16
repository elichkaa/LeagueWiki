using Microsoft.EntityFrameworkCore.Migrations;

namespace League.Data.Migrations
{
    public partial class RemovePartType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Champions_PartType_PartTypeId",
                table: "Champions");

            migrationBuilder.DropTable(
                name: "PartType");

            migrationBuilder.DropIndex(
                name: "IX_Champions_PartTypeId",
                table: "Champions");

            migrationBuilder.DropColumn(
                name: "PartTypeId",
                table: "Champions");

            migrationBuilder.AddColumn<string>(
                name: "PartType",
                table: "Champions",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PartType",
                table: "Champions");

            migrationBuilder.AddColumn<int>(
                name: "PartTypeId",
                table: "Champions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PartType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Champions_PartTypeId",
                table: "Champions",
                column: "PartTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Champions_PartType_PartTypeId",
                table: "Champions",
                column: "PartTypeId",
                principalTable: "PartType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
