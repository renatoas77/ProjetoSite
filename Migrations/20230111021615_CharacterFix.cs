using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FighteR_PG.Migrations
{
    public partial class CharacterFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SkilName12",
                table: "Characters",
                newName: "SkillName12");

            migrationBuilder.RenameColumn(
                name: "SkilName11",
                table: "Characters",
                newName: "SkillName11");

            migrationBuilder.RenameColumn(
                name: "SkilName10",
                table: "Characters",
                newName: "SkillName10");

            migrationBuilder.RenameColumn(
                name: "SkilName09",
                table: "Characters",
                newName: "SkillName09");

            migrationBuilder.RenameColumn(
                name: "SkilName08",
                table: "Characters",
                newName: "SkillName08");

            migrationBuilder.RenameColumn(
                name: "SkilName07",
                table: "Characters",
                newName: "SkillName07");

            migrationBuilder.RenameColumn(
                name: "SkilName06",
                table: "Characters",
                newName: "SkillName06");

            migrationBuilder.RenameColumn(
                name: "SkilName05",
                table: "Characters",
                newName: "SkillName05");

            migrationBuilder.RenameColumn(
                name: "SkilName04",
                table: "Characters",
                newName: "SkillName04");

            migrationBuilder.RenameColumn(
                name: "SkilName03",
                table: "Characters",
                newName: "SkillName03");

            migrationBuilder.RenameColumn(
                name: "SkilName02",
                table: "Characters",
                newName: "SkillName02");

            migrationBuilder.RenameColumn(
                name: "SkilName01",
                table: "Characters",
                newName: "SkillName01");

            migrationBuilder.RenameColumn(
                name: "SkilImage12",
                table: "Characters",
                newName: "SkillImage12");

            migrationBuilder.RenameColumn(
                name: "SkilImage11",
                table: "Characters",
                newName: "SkillImage11");

            migrationBuilder.RenameColumn(
                name: "SkilImage10",
                table: "Characters",
                newName: "SkillImage10");

            migrationBuilder.RenameColumn(
                name: "SkilImage09",
                table: "Characters",
                newName: "SkillImage09");

            migrationBuilder.RenameColumn(
                name: "SkilImage08",
                table: "Characters",
                newName: "SkillImage08");

            migrationBuilder.RenameColumn(
                name: "SkilImage07",
                table: "Characters",
                newName: "SkillImage07");

            migrationBuilder.RenameColumn(
                name: "SkilImage06",
                table: "Characters",
                newName: "SkillImage06");

            migrationBuilder.RenameColumn(
                name: "SkilImage05",
                table: "Characters",
                newName: "SkillImage05");

            migrationBuilder.RenameColumn(
                name: "SkilImage04",
                table: "Characters",
                newName: "SkillImage04");

            migrationBuilder.RenameColumn(
                name: "SkilImage03",
                table: "Characters",
                newName: "SkillImage03");

            migrationBuilder.RenameColumn(
                name: "SkilImage02",
                table: "Characters",
                newName: "SkillImage02");

            migrationBuilder.RenameColumn(
                name: "SkilImage01",
                table: "Characters",
                newName: "SkillImage01");

            migrationBuilder.RenameColumn(
                name: "SkilDesc12",
                table: "Characters",
                newName: "SkillDesc12");

            migrationBuilder.RenameColumn(
                name: "SkilDesc11",
                table: "Characters",
                newName: "SkillDesc11");

            migrationBuilder.RenameColumn(
                name: "SkilDesc10",
                table: "Characters",
                newName: "SkillDesc10");

            migrationBuilder.RenameColumn(
                name: "SkilDesc09",
                table: "Characters",
                newName: "SkillDesc09");

            migrationBuilder.RenameColumn(
                name: "SkilDesc08",
                table: "Characters",
                newName: "SkillDesc08");

            migrationBuilder.RenameColumn(
                name: "SkilDesc07",
                table: "Characters",
                newName: "SkillDesc07");

            migrationBuilder.RenameColumn(
                name: "SkilDesc06",
                table: "Characters",
                newName: "SkillDesc06");

            migrationBuilder.RenameColumn(
                name: "SkilDesc05",
                table: "Characters",
                newName: "SkillDesc05");

            migrationBuilder.RenameColumn(
                name: "SkilDesc04",
                table: "Characters",
                newName: "SkillDesc04");

            migrationBuilder.RenameColumn(
                name: "SkilDesc03",
                table: "Characters",
                newName: "SkillDesc03");

            migrationBuilder.RenameColumn(
                name: "SkilDesc02",
                table: "Characters",
                newName: "SkillDesc02");

            migrationBuilder.RenameColumn(
                name: "SkilDesc01",
                table: "Characters",
                newName: "SkillDesc01");

            migrationBuilder.RenameColumn(
                name: "Hobbie",
                table: "Characters",
                newName: "Hobby");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SkillName12",
                table: "Characters",
                newName: "SkilName12");

            migrationBuilder.RenameColumn(
                name: "SkillName11",
                table: "Characters",
                newName: "SkilName11");

            migrationBuilder.RenameColumn(
                name: "SkillName10",
                table: "Characters",
                newName: "SkilName10");

            migrationBuilder.RenameColumn(
                name: "SkillName09",
                table: "Characters",
                newName: "SkilName09");

            migrationBuilder.RenameColumn(
                name: "SkillName08",
                table: "Characters",
                newName: "SkilName08");

            migrationBuilder.RenameColumn(
                name: "SkillName07",
                table: "Characters",
                newName: "SkilName07");

            migrationBuilder.RenameColumn(
                name: "SkillName06",
                table: "Characters",
                newName: "SkilName06");

            migrationBuilder.RenameColumn(
                name: "SkillName05",
                table: "Characters",
                newName: "SkilName05");

            migrationBuilder.RenameColumn(
                name: "SkillName04",
                table: "Characters",
                newName: "SkilName04");

            migrationBuilder.RenameColumn(
                name: "SkillName03",
                table: "Characters",
                newName: "SkilName03");

            migrationBuilder.RenameColumn(
                name: "SkillName02",
                table: "Characters",
                newName: "SkilName02");

            migrationBuilder.RenameColumn(
                name: "SkillName01",
                table: "Characters",
                newName: "SkilName01");

            migrationBuilder.RenameColumn(
                name: "SkillImage12",
                table: "Characters",
                newName: "SkilImage12");

            migrationBuilder.RenameColumn(
                name: "SkillImage11",
                table: "Characters",
                newName: "SkilImage11");

            migrationBuilder.RenameColumn(
                name: "SkillImage10",
                table: "Characters",
                newName: "SkilImage10");

            migrationBuilder.RenameColumn(
                name: "SkillImage09",
                table: "Characters",
                newName: "SkilImage09");

            migrationBuilder.RenameColumn(
                name: "SkillImage08",
                table: "Characters",
                newName: "SkilImage08");

            migrationBuilder.RenameColumn(
                name: "SkillImage07",
                table: "Characters",
                newName: "SkilImage07");

            migrationBuilder.RenameColumn(
                name: "SkillImage06",
                table: "Characters",
                newName: "SkilImage06");

            migrationBuilder.RenameColumn(
                name: "SkillImage05",
                table: "Characters",
                newName: "SkilImage05");

            migrationBuilder.RenameColumn(
                name: "SkillImage04",
                table: "Characters",
                newName: "SkilImage04");

            migrationBuilder.RenameColumn(
                name: "SkillImage03",
                table: "Characters",
                newName: "SkilImage03");

            migrationBuilder.RenameColumn(
                name: "SkillImage02",
                table: "Characters",
                newName: "SkilImage02");

            migrationBuilder.RenameColumn(
                name: "SkillImage01",
                table: "Characters",
                newName: "SkilImage01");

            migrationBuilder.RenameColumn(
                name: "SkillDesc12",
                table: "Characters",
                newName: "SkilDesc12");

            migrationBuilder.RenameColumn(
                name: "SkillDesc11",
                table: "Characters",
                newName: "SkilDesc11");

            migrationBuilder.RenameColumn(
                name: "SkillDesc10",
                table: "Characters",
                newName: "SkilDesc10");

            migrationBuilder.RenameColumn(
                name: "SkillDesc09",
                table: "Characters",
                newName: "SkilDesc09");

            migrationBuilder.RenameColumn(
                name: "SkillDesc08",
                table: "Characters",
                newName: "SkilDesc08");

            migrationBuilder.RenameColumn(
                name: "SkillDesc07",
                table: "Characters",
                newName: "SkilDesc07");

            migrationBuilder.RenameColumn(
                name: "SkillDesc06",
                table: "Characters",
                newName: "SkilDesc06");

            migrationBuilder.RenameColumn(
                name: "SkillDesc05",
                table: "Characters",
                newName: "SkilDesc05");

            migrationBuilder.RenameColumn(
                name: "SkillDesc04",
                table: "Characters",
                newName: "SkilDesc04");

            migrationBuilder.RenameColumn(
                name: "SkillDesc03",
                table: "Characters",
                newName: "SkilDesc03");

            migrationBuilder.RenameColumn(
                name: "SkillDesc02",
                table: "Characters",
                newName: "SkilDesc02");

            migrationBuilder.RenameColumn(
                name: "SkillDesc01",
                table: "Characters",
                newName: "SkilDesc01");

            migrationBuilder.RenameColumn(
                name: "Hobby",
                table: "Characters",
                newName: "Hobbie");
        }
    }
}
