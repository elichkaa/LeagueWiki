using Microsoft.EntityFrameworkCore.Migrations;

namespace League.Data.Migrations
{
    public partial class AnotherTryWithItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemItemsFrom_ItemFrom_ItemFromId",
                table: "ItemItemsFrom");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemItemsFrom_Items_ItemId",
                table: "ItemItemsFrom");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemItemsTo_Items_ItemId",
                table: "ItemItemsTo");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemItemsTo_ItemTo_ItemToId",
                table: "ItemItemsTo");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemsFrom_ItemsFromId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemsTo_ItemsToId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "ItemFrom");

            migrationBuilder.DropTable(
                name: "ItemTo");

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

            migrationBuilder.RenameColumn(
                name: "ItemToId",
                table: "ItemItemsTo",
                newName: "ItemsToId");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "ItemItemsTo",
                newName: "ItemsId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemItemsTo_ItemToId",
                table: "ItemItemsTo",
                newName: "IX_ItemItemsTo_ItemsToId");

            migrationBuilder.RenameColumn(
                name: "ItemFromId",
                table: "ItemItemsFrom",
                newName: "ItemsId");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "ItemItemsFrom",
                newName: "ItemsFromId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemItemsFrom_ItemFromId",
                table: "ItemItemsFrom",
                newName: "IX_ItemItemsFrom_ItemsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemItemsFrom_Items_ItemsId",
                table: "ItemItemsFrom",
                column: "ItemsId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemItemsFrom_ItemsFrom_ItemsFromId",
                table: "ItemItemsFrom",
                column: "ItemsFromId",
                principalTable: "ItemsFrom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemItemsTo_Items_ItemsId",
                table: "ItemItemsTo",
                column: "ItemsId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemItemsTo_ItemsTo_ItemsToId",
                table: "ItemItemsTo",
                column: "ItemsToId",
                principalTable: "ItemsTo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemItemsFrom_Items_ItemsId",
                table: "ItemItemsFrom");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemItemsFrom_ItemsFrom_ItemsFromId",
                table: "ItemItemsFrom");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemItemsTo_Items_ItemsId",
                table: "ItemItemsTo");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemItemsTo_ItemsTo_ItemsToId",
                table: "ItemItemsTo");

            migrationBuilder.RenameColumn(
                name: "ItemsToId",
                table: "ItemItemsTo",
                newName: "ItemToId");

            migrationBuilder.RenameColumn(
                name: "ItemsId",
                table: "ItemItemsTo",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemItemsTo_ItemsToId",
                table: "ItemItemsTo",
                newName: "IX_ItemItemsTo_ItemToId");

            migrationBuilder.RenameColumn(
                name: "ItemsId",
                table: "ItemItemsFrom",
                newName: "ItemFromId");

            migrationBuilder.RenameColumn(
                name: "ItemsFromId",
                table: "ItemItemsFrom",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemItemsFrom_ItemsId",
                table: "ItemItemsFrom",
                newName: "IX_ItemItemsFrom_ItemFromId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemsFromId",
                table: "Items",
                column: "ItemsFromId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemsToId",
                table: "Items",
                column: "ItemsToId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemItemsFrom_ItemFrom_ItemFromId",
                table: "ItemItemsFrom",
                column: "ItemFromId",
                principalTable: "ItemFrom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemItemsFrom_Items_ItemId",
                table: "ItemItemsFrom",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemItemsTo_Items_ItemId",
                table: "ItemItemsTo",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemItemsTo_ItemTo_ItemToId",
                table: "ItemItemsTo",
                column: "ItemToId",
                principalTable: "ItemTo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
