using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GaziKultur.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kutuphaneler",
                columns: table => new
                {
                    KutuphaneID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KisaAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CalismaGunleri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcilisSaati = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KapanisSaati = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InternetVarMi = table.Column<bool>(type: "bit", nullable: false),
                    BilgisayarVarMi = table.Column<bool>(type: "bit", nullable: false),
                    CalismaAlaniVarMi = table.Column<bool>(type: "bit", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HaritaLinki = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kutuphaneler", x => x.KutuphaneID);
                });

            migrationBuilder.CreateTable(
                name: "Muzeler",
                columns: table => new
                {
                    MuzeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KisaAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarihce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZiyaretGunleri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcilisSaati = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KapanisSaati = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GirisUcreti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HaritaLinki = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muzeler", x => x.MuzeID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kutuphaneler");

            migrationBuilder.DropTable(
                name: "Muzeler");
        }
    }
}
