using Microsoft.EntityFrameworkCore.Migrations;

namespace League.Data.Migrations
{
    public partial class AddPassiveAndLore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PassiveId",
                table: "Champions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Passive",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passive", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Passive_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Champions_PassiveId",
                table: "Champions",
                column: "PassiveId");

            migrationBuilder.CreateIndex(
                name: "IX_Passive_ImageId",
                table: "Passive",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Champions_Passive_PassiveId",
                table: "Champions",
                column: "PassiveId",
                principalTable: "Passive",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Champions_Passive_PassiveId",
                table: "Champions");

            migrationBuilder.DropTable(
                name: "Passive");

            migrationBuilder.DropIndex(
                name: "IX_Champions_PassiveId",
                table: "Champions");

            migrationBuilder.DropColumn(
                name: "PassiveId",
                table: "Champions");
        }
    }
}
