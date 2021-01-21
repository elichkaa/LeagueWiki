using Microsoft.EntityFrameworkCore.Migrations;

namespace League.Data.Migrations
{
    public partial class AddItemsStats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Consumable",
                table: "Items",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ConsumedOnFull",
                table: "Items",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HideFromAll",
                table: "Items",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "InStore",
                table: "Items",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemStatsId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RequiredChampion",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RiotId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpecialRecipe",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Stacks",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ItemStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlatMovementSpeedMod = table.Column<int>(type: "int", nullable: true),
                    FlatHPPoolMod = table.Column<int>(type: "int", nullable: true),
                    FlatCritChanceMod = table.Column<double>(type: "float", nullable: true),
                    FlatMagicDamageMod = table.Column<int>(type: "int", nullable: true),
                    FlatMPPoolMod = table.Column<int>(type: "int", nullable: true),
                    FlatArmorMod = table.Column<int>(type: "int", nullable: true),
                    FlatSpellBlockMod = table.Column<int>(type: "int", nullable: true),
                    FlatPhysicalDamageMod = table.Column<int>(type: "int", nullable: true),
                    PercentAttackSpeedMod = table.Column<double>(type: "float", nullable: true),
                    PercentLifeStealMod = table.Column<double>(type: "float", nullable: true),
                    FlatHPRegenMod = table.Column<double>(type: "float", nullable: true),
                    PercentMovementSpeedMod = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemStats", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemStatsId",
                table: "Items",
                column: "ItemStatsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemStats_ItemStatsId",
                table: "Items",
                column: "ItemStatsId",
                principalTable: "ItemStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemStats_ItemStatsId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "ItemStats");

            migrationBuilder.DropIndex(
                name: "IX_Items_ItemStatsId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Consumable",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ConsumedOnFull",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "HideFromAll",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "InStore",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemStatsId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "RequiredChampion",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "RiotId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SpecialRecipe",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Stacks",
                table: "Items");
        }
    }
}
