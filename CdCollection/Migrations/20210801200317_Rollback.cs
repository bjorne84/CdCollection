using Microsoft.EntityFrameworkCore.Migrations;

namespace CdCollection.Migrations
{
    public partial class Rollback : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArtistName",
                table: "Cds");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArtistName",
                table: "Cds",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
