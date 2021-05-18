using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NLayerProject.Data.Migrations
{
    public partial class AddOrderDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiparisBagID = table.Column<int>(nullable: false),
                    Firma = table.Column<int>(nullable: false),
                    Sirket = table.Column<int>(nullable: false),
                    KayitTipi = table.Column<int>(nullable: false),
                    EvrakTipi = table.Column<int>(nullable: false),
                    Tip = table.Column<int>(nullable: false),
                    Tur = table.Column<int>(nullable: false),
                    Tarih = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    Saat = table.Column<DateTime>(type: "datetime", nullable: false),
                    Termin = table.Column<DateTime>(type: "datetime", nullable: false),
                    Seri = table.Column<string>(maxLength: 5, nullable: true),
                    SeriNo = table.Column<string>(maxLength: 20, nullable: true),
                    GonderenID = table.Column<int>(nullable: false),
                    GonderenUnvan = table.Column<string>(maxLength: 100, nullable: true),
                    GonderenFaturaAdresID = table.Column<int>(nullable: false),
                    GonderenFaturaAdresUnvan = table.Column<string>(maxLength: 100, nullable: true),
                    YuklemeHesapID = table.Column<int>(nullable: false),
                    YuklemeHesapUnvan = table.Column<string>(maxLength: 100, nullable: true),
                    YuklemeAdresID = table.Column<int>(nullable: false),
                    YuklemeAdresFaturaUnvan = table.Column<string>(maxLength: 100, nullable: true),
                    YuklemeSehir = table.Column<string>(maxLength: 20, nullable: true),
                    YuklemeSehirAdi = table.Column<string>(maxLength: 50, nullable: true),
                    YuklemeSube = table.Column<string>(maxLength: 20, nullable: true),
                    YuklemeSubeAdi = table.Column<string>(maxLength: 50, nullable: true),
                    AliciID = table.Column<int>(nullable: false),
                    AliciUnvan = table.Column<string>(maxLength: 100, nullable: true),
                    AliciFaturaAdresID = table.Column<int>(nullable: false),
                    AliciFaturaAdresUnvan = table.Column<string>(maxLength: 100, nullable: true),
                    AliciTeslimAdresID = table.Column<int>(nullable: false),
                    AliciTeslimAdresUnvan = table.Column<string>(maxLength: 100, nullable: true),
                    AliciTeslimSehir = table.Column<string>(maxLength: 20, nullable: true),
                    AliciTeslimSehirAdi = table.Column<string>(maxLength: 50, nullable: true),
                    AliciTeslimSube = table.Column<string>(maxLength: 20, nullable: true),
                    AliciTeslimSubeAdi = table.Column<string>(maxLength: 50, nullable: true),
                    NakliyeHesapID = table.Column<int>(nullable: false),
                    NakliyeHesapUnvan = table.Column<string>(maxLength: 100, nullable: true),
                    NakliyeHesapFaturaID = table.Column<int>(nullable: false),
                    NakliyeHesapFaturaUnvan = table.Column<string>(maxLength: 100, nullable: true),
                    FiyatTipi = table.Column<int>(nullable: false),
                    OdemeSekli = table.Column<int>(nullable: false),
                    OdmeTuru = table.Column<int>(nullable: false),
                    TeslimTipi = table.Column<int>(nullable: false),
                    FaturaTip = table.Column<int>(nullable: false),
                    Aciklama = table.Column<string>(maxLength: 300, nullable: true),
                    Aciklama2 = table.Column<string>(maxLength: 100, nullable: true),
                    Aciklama3 = table.Column<string>(maxLength: 100, nullable: true),
                    ProjeId = table.Column<int>(nullable: false),
                    AltProjeId = table.Column<int>(nullable: false),
                    Iptal = table.Column<bool>(nullable: false),
                    Silindi = table.Column<bool>(nullable: false),
                    SilmeNedeni = table.Column<string>(maxLength: 100, nullable: true),
                    KayitBy = table.Column<string>(maxLength: 20, nullable: true),
                    KayitDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    DegisBy = table.Column<string>(maxLength: 20, nullable: true),
                    DegisDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(nullable: false),
                    Aciklama = table.Column<string>(maxLength: 100, nullable: true),
                    Aciklama2 = table.Column<string>(maxLength: 100, nullable: true),
                    StokID = table.Column<int>(maxLength: 40, nullable: false),
                    StokKodu = table.Column<string>(maxLength: 40, nullable: true),
                    StokAdi = table.Column<string>(maxLength: 100, nullable: true),
                    Birim = table.Column<string>(maxLength: 10, nullable: true),
                    Miktar = table.Column<decimal>(type: "decimal (18,6)", nullable: false),
                    Birim2 = table.Column<string>(maxLength: 10, nullable: true),
                    Miktar2 = table.Column<decimal>(type: "decimal (18,6)", nullable: false),
                    Birim3 = table.Column<string>(maxLength: 10, nullable: true),
                    Miktar3 = table.Column<decimal>(type: "decimal (18,6)", nullable: false),
                    BirimKg = table.Column<decimal>(type: "decimal (18,6)", nullable: false),
                    Kg = table.Column<decimal>(type: "decimal (18,6)", nullable: false),
                    BirimDesi = table.Column<decimal>(type: "decimal (18,6)", nullable: false),
                    Desi = table.Column<decimal>(type: "decimal (18,6)", nullable: false),
                    BirimM3 = table.Column<decimal>(type: "decimal (18,6)", nullable: false),
                    M3 = table.Column<decimal>(type: "decimal (18,6)", nullable: false),
                    HesapBirim = table.Column<string>(maxLength: 10, nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal (18,6)", nullable: false),
                    Tutar = table.Column<decimal>(type: "decimal (18,6)", nullable: false),
                    Masraf = table.Column<decimal>(type: "decimal (18,6)", nullable: false),
                    MasrafNakliye = table.Column<decimal>(type: "decimal (18,6)", nullable: false),
                    BrutTutar = table.Column<decimal>(type: "decimal (18,6)", nullable: false),
                    KdvOran = table.Column<decimal>(type: "decimal (18,6)", nullable: false),
                    Kdv = table.Column<decimal>(type: "decimal (18,6)", nullable: false),
                    Toplam = table.Column<decimal>(type: "decimal (18,6)", nullable: false),
                    DagitimIrsNo = table.Column<string>(maxLength: 500, nullable: true),
                    MusteriIrsNo = table.Column<string>(maxLength: 500, nullable: true),
                    Durum = table.Column<int>(nullable: false),
                    KayitBy = table.Column<string>(maxLength: 20, nullable: true),
                    KayitDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    DegisBy = table.Column<string>(maxLength: 20, nullable: true),
                    DegisDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    OrderID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
