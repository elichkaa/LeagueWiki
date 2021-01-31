using Microsoft.EntityFrameworkCore.Migrations;

namespace League.Data.Migrations
{
    public partial class AddRecommended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "BlockItem",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    BlockId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockItem", x => new { x.ItemId, x.BlockId });
                    table.ForeignKey(
                        name: "FK_BlockItem_Block_BlockId",
                        column: x => x.BlockId,
                        principalTable: "Block",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlockItem_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Block_RecommendedId",
                table: "Block",
                column: "RecommendedId");

            migrationBuilder.CreateIndex(
                name: "IX_BlockItem_BlockId",
                table: "BlockItem",
                column: "BlockId");

            migrationBuilder.CreateIndex(
                name: "IX_Recommended_ChampionId",
                table: "Recommended",
                column: "ChampionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlockItem");

            migrationBuilder.DropTable(
                name: "Block");

            migrationBuilder.DropTable(
                name: "Recommended");
        }
    }
}
