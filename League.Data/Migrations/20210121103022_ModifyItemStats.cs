using Microsoft.EntityFrameworkCore.Migrations;

namespace League.Data.Migrations
{
    public partial class ModifyItemStats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "RequiredChampion",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SpecialRecipe",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Stacks",
                table: "Items");

            migrationBuilder.AddColumn<bool>(
                name: "Consumable",
                table: "ItemStats",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ConsumedOnFull",
                table: "ItemStats",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HideFromAll",
                table: "ItemStats",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "InStore",
                table: "ItemStats",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequiredChampion",
                table: "ItemStats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpecialRecipe",
                table: "ItemStats",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Stacks",
                table: "ItemStats",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Consumable",
                table: "ItemStats");

            migrationBuilder.DropColumn(
                name: "ConsumedOnFull",
                table: "ItemStats");

            migrationBuilder.DropColumn(
                name: "HideFromAll",
                table: "ItemStats");

            migrationBuilder.DropColumn(
                name: "InStore",
                table: "ItemStats");

            migrationBuilder.DropColumn(
                name: "RequiredChampion",
                table: "ItemStats");

            migrationBuilder.DropColumn(
                name: "SpecialRecipe",
                table: "ItemStats");

            migrationBuilder.DropColumn(
                name: "Stacks",
                table: "ItemStats");

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

            migrationBuilder.AddColumn<string>(
                name: "RequiredChampion",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

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
        }
    }
}
