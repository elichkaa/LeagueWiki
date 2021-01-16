using Microsoft.EntityFrameworkCore.Migrations;

namespace League.Data.Migrations
{
    public partial class ModifyMapsItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_MapItem_MapId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "MapItem");

            migrationBuilder.DropIndex(
                name: "IX_Items_MapId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "MapId",
                table: "Items");

            migrationBuilder.CreateTable(
                name: "MapsItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    SummonersRift = table.Column<bool>(type: "bit", nullable: false),
                    HowlingAbyss = table.Column<bool>(type: "bit", nullable: false),
                    NexusBlitz = table.Column<bool>(type: "bit", nullable: false),
                    TFT = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapsItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MapsItem_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MapsItem_ItemId",
                table: "MapsItem",
                column: "ItemId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MapsItem");

            migrationBuilder.AddColumn<int>(
                name: "MapId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MapItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    MapId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MapItem_Map_MapId",
                        column: x => x.MapId,
                        principalTable: "Map",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_MapId",
                table: "Items",
                column: "MapId");

            migrationBuilder.CreateIndex(
                name: "IX_MapItem_MapId",
                table: "MapItem",
                column: "MapId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_MapItem_MapId",
                table: "Items",
                column: "MapId",
                principalTable: "MapItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
