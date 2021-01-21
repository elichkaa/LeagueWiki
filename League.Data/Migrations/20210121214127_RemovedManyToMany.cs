using Microsoft.EntityFrameworkCore.Migrations;

namespace League.Data.Migrations
{
    public partial class RemovedManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemRelationship");

            migrationBuilder.DropTable(
                name: "ItemsTo");

            migrationBuilder.AddColumn<string>(
                name: "ItemsFrom",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemsTo",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemsFrom",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemsTo",
                table: "Items");

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
                    CompactItemId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
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
    }
}
