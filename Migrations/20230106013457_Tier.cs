using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FighteR_PG.Migrations
{
    public partial class Tier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TierId",
                table: "Bosses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Tier",
                columns: table => new
                {
                    TierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tier", x => x.TierId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bosses_TierId",
                table: "Bosses",
                column: "TierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bosses_Tier_TierId",
                table: "Bosses",
                column: "TierId",
                principalTable: "Tier",
                principalColumn: "TierId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bosses_Tier_TierId",
                table: "Bosses");

            migrationBuilder.DropTable(
                name: "Tier");

            migrationBuilder.DropIndex(
                name: "IX_Bosses_TierId",
                table: "Bosses");

            migrationBuilder.DropColumn(
                name: "TierId",
                table: "Bosses");
        }
    }
}
