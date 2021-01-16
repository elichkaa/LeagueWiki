using Microsoft.EntityFrameworkCore.Migrations;

namespace League.Data.Migrations
{
    public partial class FixMapsItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MapsItem_Items_ItemId",
                table: "MapsItem");

            migrationBuilder.DropIndex(
                name: "IX_MapsItem_ItemId",
                table: "MapsItem");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "MapsItem");

            migrationBuilder.RenameColumn(
                name: "MapsItemsId",
                table: "Items",
                newName: "MapsItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_MapsItemId",
                table: "Items",
                column: "MapsItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_MapsItem_MapsItemId",
                table: "Items",
                column: "MapsItemId",
                principalTable: "MapsItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_MapsItem_MapsItemId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_MapsItemId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "MapsItemId",
                table: "Items",
                newName: "MapsItemsId");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "MapsItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MapsItem_ItemId",
                table: "MapsItem",
                column: "ItemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MapsItem_Items_ItemId",
                table: "MapsItem",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
