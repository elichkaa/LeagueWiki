using Microsoft.EntityFrameworkCore.Migrations;

namespace League.Data.Migrations
{
    public partial class AddRecommendedAndLore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlockId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Recommended",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChampionId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MapName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recommended", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recommended_Champions_ChampionId",
                        column: x => x.ChampionId,
                        principalTable: "Champions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Block",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinSummonerLevel = table.Column<int>(type: "int", nullable: false),
                    MaxSummonerLevel = table.Column<int>(type: "int", nullable: false),
                    ShowIfSummonerSpell = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HideIfSummonerSpell = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecommendedId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Block", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Block_Recommended_RecommendedId",
                        column: x => x.RecommendedId,
                        principalTable: "Recommended",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_BlockId",
                table: "Items",
                column: "BlockId");

            migrationBuilder.CreateIndex(
                name: "IX_Block_RecommendedId",
                table: "Block",
                column: "RecommendedId");

            migrationBuilder.CreateIndex(
                name: "IX_Recommended_ChampionId",
                table: "Recommended",
                column: "ChampionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Block_BlockId",
                table: "Items",
                column: "BlockId",
                principalTable: "Block",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Block_BlockId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "Block");

            migrationBuilder.DropTable(
                name: "Recommended");

            migrationBuilder.DropIndex(
                name: "IX_Items_BlockId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "BlockId",
                table: "Items");
        }
    }
}
