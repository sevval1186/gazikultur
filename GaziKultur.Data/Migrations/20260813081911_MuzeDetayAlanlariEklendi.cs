using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GaziKultur.Data.Migrations
{
    /// <inheritdoc />
    public partial class MuzeDetayAlanlariEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Eposta",
                table: "Muzeler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GiseKapanisSaati",
                table: "Muzeler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MuzekartBilgisi",
                table: "Muzeler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "Muzeler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UcretEuro",
                table: "Muzeler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UcretTL",
                table: "Muzeler",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Eposta",
                table: "Muzeler");

            migrationBuilder.DropColumn(
                name: "GiseKapanisSaati",
                table: "Muzeler");

            migrationBuilder.DropColumn(
                name: "MuzekartBilgisi",
                table: "Muzeler");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "Muzeler");

            migrationBuilder.DropColumn(
                name: "UcretEuro",
                table: "Muzeler");

            migrationBuilder.DropColumn(
                name: "UcretTL",
                table: "Muzeler");
        }
    }
}
