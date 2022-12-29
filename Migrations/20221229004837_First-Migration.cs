using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FighteR_PG.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Archetypes",
                columns: table => new
                {
                    ArchetypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archetypes", x => x.ArchetypeId);
                });

            migrationBuilder.CreateTable(
                name: "Sexes",
                columns: table => new
                {
                    SexId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SexCharacter = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexes", x => x.SexId);
                });

            migrationBuilder.CreateTable(
                name: "Bosses",
                columns: table => new
                {
                    BossId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegionImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GerneralText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SexId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bosses", x => x.BossId);
                    table.ForeignKey(
                        name: "FK_Bosses_Sexes_SexId",
                        column: x => x.SexId,
                        principalTable: "Sexes",
                        principalColumn: "SexId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Likes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dislikes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hobbie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Food = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Curiosity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ideias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Conclusao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilName01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilName02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilName03 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilName04 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilName05 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilName06 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilName07 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilName08 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilName09 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilName10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilName11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilName12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilDesc01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilDesc02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilDesc03 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilDesc04 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilDesc05 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilDesc06 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilDesc07 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilDesc08 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilDesc09 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilDesc10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilDesc11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilDesc12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilImage01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilImage02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilImage03 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilImage04 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilImage05 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilImage06 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilImage07 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilImage08 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilImage09 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilImage10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilImage11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkilImage12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Special01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Special02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialDesc01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialDesc02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialImage01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialImage02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fury = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hit01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hit02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StandComboImage01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StandComboImage02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WalkingComboImage01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WalkingComboImage02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RunningComboImage01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RunningComboImage02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JumpComboImage01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JumpComboImage02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RunningJumpComboImage01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RunningJumpComboImage02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StandCombo01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StandCombo02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WalkingCombo01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WalkingCombo02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RunningCombo01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RunningCombo02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JumpCombo01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JumpCombo02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RunningJumpCombo01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RunningJumpCombo02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchetypeId = table.Column<int>(type: "int", nullable: false),
                    SexId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                    table.ForeignKey(
                        name: "FK_Characters_Archetypes_ArchetypeId",
                        column: x => x.ArchetypeId,
                        principalTable: "Archetypes",
                        principalColumn: "ArchetypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Sexes_SexId",
                        column: x => x.SexId,
                        principalTable: "Sexes",
                        principalColumn: "SexId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bosses_SexId",
                table: "Bosses",
                column: "SexId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ArchetypeId",
                table: "Characters",
                column: "ArchetypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_SexId",
                table: "Characters",
                column: "SexId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bosses");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Archetypes");

            migrationBuilder.DropTable(
                name: "Sexes");
        }
    }
}
