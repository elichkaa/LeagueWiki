using Microsoft.EntityFrameworkCore.Migrations;

namespace League.Data.Migrations
{
    public partial class ChangedUpStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "ItemsFrom");

            migrationBuilder.DropTable(
                name: "ItemsTo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemItemsTo",
                table: "ItemItemsTo");

            migrationBuilder.DropIndex(
                name: "IX_ItemItemsTo_ItemsToId",
                table: "ItemItemsTo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemItemsFrom",
                table: "ItemItemsFrom");

            migrationBuilder.DropIndex(
                name: "IX_ItemItemsFrom_ItemsId",
                table: "ItemItemsFrom");

            migrationBuilder.RenameColumn(
                name: "ItemsToId",
                table: "ItemItemsTo",
                newName: "RiotId");

            migrationBuilder.RenameColumn(
                name: "ItemsId",
                table: "ItemItemsTo",
                newName: "ItemToId");

            migrationBuilder.RenameColumn(
                name: "ItemsId",
                table: "ItemItemsFrom",
                newName: "RiotId");

            migrationBuilder.RenameColumn(
                name: "ItemsFromId",
                table: "ItemItemsFrom",
                newName: "ItemFromId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ItemItemsTo",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "ItemItemsTo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ItemItemsFrom",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "ItemItemsFrom",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemItemsTo",
                table: "ItemItemsTo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemItemsFrom",
                table: "ItemItemsFrom",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemItemsTo_ItemId",
                table: "ItemItemsTo",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemItemsFrom_ItemId",
                table: "ItemItemsFrom",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemItemsFrom_Items_ItemId",
                table: "ItemItemsFrom",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemItemsTo_Items_ItemId",
                table: "ItemItemsTo",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemItemsFrom_Items_ItemId",
                table: "ItemItemsFrom");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemItemsTo_Items_ItemId",
                table: "ItemItemsTo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemItemsTo",
                table: "ItemItemsTo");

            migrationBuilder.DropIndex(
                name: "IX_ItemItemsTo_ItemId",
                table: "ItemItemsTo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemItemsFrom",
                table: "ItemItemsFrom");

            migrationBuilder.DropIndex(
                name: "IX_ItemItemsFrom_ItemId",
                table: "ItemItemsFrom");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ItemItemsTo");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "ItemItemsTo");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ItemItemsFrom");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "ItemItemsFrom");

            migrationBuilder.RenameColumn(
                name: "RiotId",
                table: "ItemItemsTo",
                newName: "ItemsToId");

            migrationBuilder.RenameColumn(
                name: "ItemToId",
                table: "ItemItemsTo",
                newName: "ItemsId");

            migrationBuilder.RenameColumn(
                name: "RiotId",
                table: "ItemItemsFrom",
                newName: "ItemsId");

            migrationBuilder.RenameColumn(
                name: "ItemFromId",
                table: "ItemItemsFrom",
                newName: "ItemsFromId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemItemsTo",
                table: "ItemItemsTo",
                columns: new[] { "ItemsId", "ItemsToId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemItemsFrom",
                table: "ItemItemsFrom",
                columns: new[] { "ItemsFromId", "ItemsId" });

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
                name: "IX_ItemItemsTo_ItemsToId",
                table: "ItemItemsTo",
                column: "ItemsToId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemItemsFrom_ItemsId",
                table: "ItemItemsFrom",
                column: "ItemsId");

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
    }
}
