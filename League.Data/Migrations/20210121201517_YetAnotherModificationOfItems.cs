using Microsoft.EntityFrameworkCore.Migrations;

namespace League.Data.Migrations
{
    public partial class YetAnotherModificationOfItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemsFromId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemsToId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ItemsFrom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsFrom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemsTo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsTo", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemsFromId",
                table: "Items",
                column: "ItemsFromId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemsToId",
                table: "Items",
                column: "ItemsToId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemsFrom_ItemsFromId",
                table: "Items",
                column: "ItemsFromId",
                principalTable: "ItemsFrom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemsTo_ItemsToId",
                table: "Items",
                column: "ItemsToId",
                principalTable: "ItemsTo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemsFrom_ItemsFromId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemsTo_ItemsToId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "ItemsFrom");

            migrationBuilder.DropTable(
                name: "ItemsTo");

            migrationBuilder.DropIndex(
                name: "IX_Items_ItemsFromId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ItemsToId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemsFromId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemsToId",
                table: "Items");
        }
    }
}
