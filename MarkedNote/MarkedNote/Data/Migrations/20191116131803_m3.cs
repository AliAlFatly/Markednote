using Microsoft.EntityFrameworkCore.Migrations;

namespace MarkedNote.Data.Migrations
{
    public partial class m3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LinkComment",
                table: "NoteLinks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LinkComment",
                table: "NoteLinks",
                nullable: true);
        }
    }
}
