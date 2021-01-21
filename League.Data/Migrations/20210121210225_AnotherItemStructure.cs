using Microsoft.EntityFrameworkCore.Migrations;

namespace League.Data.Migrations
{
    public partial class AnotherItemStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemItemsFrom");

            migrationBuilder.DropTable(
                name: "ItemItemsTo");

            migrationBuilder.CreateTable(
                name: "ItemsTo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsTo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemRelationship",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    CompactItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemRelationship", x => new { x.CompactItemId, x.ItemId });
                    table.ForeignKey(
                        name: "FK_ItemRelationship_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemRelationship_ItemsTo_CompactItemId",
                        column: x => x.CompactItemId,
                        principalTable: "ItemsTo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemRelationship_ItemId",
                table: "ItemRelationship",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemRelationship");

            migrationBuilder.DropTable(
                name: "ItemsTo");

            migrationBuilder.CreateTable(
                name: "ItemItemsFrom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemFromId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    RiotId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemItemsFrom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemItemsFrom_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemItemsTo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    ItemToId = table.Column<int>(type: "int", nullable: false),
                    RiotId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemItemsTo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemItemsTo_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemItemsFrom_ItemId",
                table: "ItemItemsFrom",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemItemsTo_ItemId",
                table: "ItemItemsTo",
                column: "ItemId");
        }
    }
}
