using Microsoft.EntityFrameworkCore.Migrations;

namespace NLayerProject.Data.Migrations
{
    public partial class AddCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tip = table.Column<int>(nullable: false),
                    Kod = table.Column<string>(maxLength: 50, nullable: true),
                    Tanim = table.Column<string>(maxLength: 200, nullable: true),
                    Ulke = table.Column<string>(maxLength: 50, nullable: true),
                    UlkeAdi = table.Column<string>(maxLength: 50, nullable: true),
                    Bolge = table.Column<string>(maxLength: 50, nullable: true),
                    BolgeAdi = table.Column<string>(maxLength: 50, nullable: true),
                    Sehir = table.Column<string>(maxLength: 50, nullable: true),
                    SehirAdi = table.Column<string>(maxLength: 50, nullable: true),
                    Ilce = table.Column<string>(maxLength: 50, nullable: true),
                    IlceAdi = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
