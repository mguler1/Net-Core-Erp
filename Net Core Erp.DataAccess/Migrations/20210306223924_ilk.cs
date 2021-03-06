using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Net_Core_Erp.DataAccess.Migrations
{
    public partial class ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAd = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Sifre = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Yetki = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "Caris",
                columns: table => new
                {
                    CariID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CariAd = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CariSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CariSehir = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    CariMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CariSifre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caris", x => x.CariID);
                });

            migrationBuilder.CreateTable(
                name: "Departmans",
                columns: table => new
                {
                    DepartmanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmanAd = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmans", x => x.DepartmanID);
                });

            migrationBuilder.CreateTable(
                name: "Detays",
                columns: table => new
                {
                    DetayID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAd = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    UrunBilgi = table.Column<string>(type: "nvarchar(2500)", maxLength: 2500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detays", x => x.DetayID);
                });

            migrationBuilder.CreateTable(
                name: "Faturas",
                columns: table => new
                {
                    FaturaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaturaSeriNo = table.Column<string>(type: "Char(1)", maxLength: 1, nullable: true),
                    FaturaSıraNo = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    Tarih = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Saat = table.Column<string>(type: "Char(5)", maxLength: 5, nullable: true),
                    VergiDairesi = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TeslimEden = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TeslimAlan = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Toplam = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faturas", x => x.FaturaID);
                });

            migrationBuilder.CreateTable(
                name: "Giders",
                columns: table => new
                {
                    GiderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Acıklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Giders", x => x.GiderID);
                });

            migrationBuilder.CreateTable(
                name: "KargoDetays",
                columns: table => new
                {
                    KargoDetayID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    TakipKodu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Personel = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Alici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KargoDetays", x => x.KargoDetayID);
                });

            migrationBuilder.CreateTable(
                name: "KargoTakips",
                columns: table => new
                {
                    KargoTakipID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TakipKodu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TarihZaman = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KargoTakips", x => x.KargoTakipID);
                });

            migrationBuilder.CreateTable(
                name: "Kategoris",
                columns: table => new
                {
                    KategorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAd = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoris", x => x.KategorID);
                });

            migrationBuilder.CreateTable(
                name: "Mesajlars",
                columns: table => new
                {
                    MesajId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gonderici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Alici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Konu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Icerik = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesajlars", x => x.MesajId);
                });

            migrationBuilder.CreateTable(
                name: "Yapilacaks",
                columns: table => new
                {
                    YapilacakID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Süre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yapilacaks", x => x.YapilacakID);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    PersonelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelAd = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PersonelSoyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PersonelGorsel = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    departmanid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.PersonelID);
                    table.ForeignKey(
                        name: "FK_Personels_Departmans_departmanid",
                        column: x => x.departmanid,
                        principalTable: "Departmans",
                        principalColumn: "DepartmanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FaturaKalems",
                columns: table => new
                {
                    FaturaKalemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Acıklama = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Miktar = table.Column<int>(type: "int", nullable: false),
                    BirimFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Faturaid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaturaKalems", x => x.FaturaKalemID);
                    table.ForeignKey(
                        name: "FK_FaturaKalems_Faturas_Faturaid",
                        column: x => x.Faturaid,
                        principalTable: "Faturas",
                        principalColumn: "FaturaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uruns",
                columns: table => new
                {
                    UrunID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAd = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Marka = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Stok = table.Column<short>(type: "smallint", nullable: false),
                    AlisFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SatisFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    UrunGorsel = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Kategoriid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uruns", x => x.UrunID);
                    table.ForeignKey(
                        name: "FK_Uruns_Kategoris_Kategoriid",
                        column: x => x.Kategoriid,
                        principalTable: "Kategoris",
                        principalColumn: "KategorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SatisHarekets",
                columns: table => new
                {
                    SatisID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Urunid = table.Column<int>(type: "int", nullable: false),
                    Cariid = table.Column<int>(type: "int", nullable: false),
                    Personelid = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ToplamTutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatisHarekets", x => x.SatisID);
                    table.ForeignKey(
                        name: "FK_SatisHarekets_Caris_Cariid",
                        column: x => x.Cariid,
                        principalTable: "Caris",
                        principalColumn: "CariID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SatisHarekets_Personels_Personelid",
                        column: x => x.Personelid,
                        principalTable: "Personels",
                        principalColumn: "PersonelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SatisHarekets_Uruns_Urunid",
                        column: x => x.Urunid,
                        principalTable: "Uruns",
                        principalColumn: "UrunID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FaturaKalems_Faturaid",
                table: "FaturaKalems",
                column: "Faturaid");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_departmanid",
                table: "Personels",
                column: "departmanid");

            migrationBuilder.CreateIndex(
                name: "IX_SatisHarekets_Cariid",
                table: "SatisHarekets",
                column: "Cariid");

            migrationBuilder.CreateIndex(
                name: "IX_SatisHarekets_Personelid",
                table: "SatisHarekets",
                column: "Personelid");

            migrationBuilder.CreateIndex(
                name: "IX_SatisHarekets_Urunid",
                table: "SatisHarekets",
                column: "Urunid");

            migrationBuilder.CreateIndex(
                name: "IX_Uruns_Kategoriid",
                table: "Uruns",
                column: "Kategoriid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Detays");

            migrationBuilder.DropTable(
                name: "FaturaKalems");

            migrationBuilder.DropTable(
                name: "Giders");

            migrationBuilder.DropTable(
                name: "KargoDetays");

            migrationBuilder.DropTable(
                name: "KargoTakips");

            migrationBuilder.DropTable(
                name: "Mesajlars");

            migrationBuilder.DropTable(
                name: "SatisHarekets");

            migrationBuilder.DropTable(
                name: "Yapilacaks");

            migrationBuilder.DropTable(
                name: "Faturas");

            migrationBuilder.DropTable(
                name: "Caris");

            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "Uruns");

            migrationBuilder.DropTable(
                name: "Departmans");

            migrationBuilder.DropTable(
                name: "Kategoris");
        }
    }
}
