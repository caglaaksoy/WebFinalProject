using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Veritabani : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Iceceklers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrunTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrunFiyat = table.Column<int>(type: "int", nullable: false),
                    UrunFoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iceceklers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Iceceklers_Kategoris_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tatlilars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrunTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrunFiyat = table.Column<int>(type: "int", nullable: false),
                    UrunFoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tatlilars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tatlilars_Kategoris_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Iceceklers_KategoriId",
                table: "Iceceklers",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Tatlilars_KategoriId",
                table: "Tatlilars",
                column: "KategoriId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Iceceklers");

            migrationBuilder.DropTable(
                name: "Kullanicis");

            migrationBuilder.DropTable(
                name: "Tatlilars");

            migrationBuilder.DropTable(
                name: "Kategoris");
        }
    }
}
