using Microsoft.EntityFrameworkCore.Migrations;

namespace League.Data.Migrations
{
    public partial class FixItemRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemFrom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemFrom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemTo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemItemsFrom",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ItemFromId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemItemsFrom", x => new { x.ItemId, x.ItemFromId });
                    table.ForeignKey(
                        name: "FK_ItemItemsFrom_ItemFrom_ItemFromId",
                        column: x => x.ItemFromId,
                        principalTable: "ItemFrom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemItemsFrom_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemItemsTo",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ItemToId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemItemsTo", x => new { x.ItemId, x.ItemToId });
                    table.ForeignKey(
                        name: "FK_ItemItemsTo_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemItemsTo_ItemTo_ItemToId",
                        column: x => x.ItemToId,
                        principalTable: "ItemTo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemItemsFrom_ItemFromId",
                table: "ItemItemsFrom",
                column: "ItemFromId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemItemsTo_ItemToId",
                table: "ItemItemsTo",
                column: "ItemToId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemItemsFrom");

            migrationBuilder.DropTable(
                name: "ItemItemsTo");

            migrationBuilder.DropTable(
                name: "ItemFrom");

            migrationBuilder.DropTable(
                name: "ItemTo");
        }
    }
}
