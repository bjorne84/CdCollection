using Microsoft.EntityFrameworkCore.Migrations;

namespace CdCollection.Migrations
{
    public partial class ArtistId2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cds_Artists_ArtistId",
                table: "Cds");

            migrationBuilder.DropIndex(
                name: "IX_Cds_ArtistId",
                table: "Cds");

            migrationBuilder.AlterColumn<string>(
                name: "ArtistId",
                table: "Cds",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ArtistId1",
                table: "Cds",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cds_ArtistId1",
                table: "Cds",
                column: "ArtistId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cds_Artists_ArtistId1",
                table: "Cds",
                column: "ArtistId1",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cds_Artists_ArtistId1",
                table: "Cds");

            migrationBuilder.DropIndex(
                name: "IX_Cds_ArtistId1",
                table: "Cds");

            migrationBuilder.DropColumn(
                name: "ArtistId1",
                table: "Cds");

            migrationBuilder.AlterColumn<int>(
                name: "ArtistId",
                table: "Cds",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cds_ArtistId",
                table: "Cds",
                column: "ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cds_Artists_ArtistId",
                table: "Cds",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
