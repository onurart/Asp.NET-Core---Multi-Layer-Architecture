using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NLayerProject.Data.Migrations
{
    public partial class AddCustomerColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "Customers",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adres2",
                table: "Customers",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bolge",
                table: "Customers",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DegisBy",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DegisDate",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FaturaCariHesapKodu",
                table: "Customers",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FaturaCariID",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FaturaCariUnvan",
                table: "Customers",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fax",
                table: "Customers",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Firma",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HesapKodu",
                table: "Customers",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HesapTipi",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HesapTuru",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsPasif",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "KayitBy",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OdemeGun",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PostaKodu",
                table: "Customers",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sehir",
                table: "Customers",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SehirAdi",
                table: "Customers",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Semt",
                table: "Customers",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Silindi",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Sirket",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SubeAdi",
                table: "Customers",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubeKodu",
                table: "Customers",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TCNo",
                table: "Customers",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tel1",
                table: "Customers",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tel2",
                table: "Customers",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ulke",
                table: "Customers",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Unvan",
                table: "Customers",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "VadeGun",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "VergiDairesi",
                table: "Customers",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VergiNo",
                table: "Customers",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Yetkili",
                table: "Customers",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YetkiliEmail",
                table: "Customers",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YetkiliTel1",
                table: "Customers",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YetkiliTel2",
                table: "Customers",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "kayitDate",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adres",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Adres2",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Bolge",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DegisBy",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DegisDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "FaturaCariHesapKodu",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "FaturaCariID",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "FaturaCariUnvan",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Fax",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Firma",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "HesapKodu",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "HesapTipi",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "HesapTuru",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "IsPasif",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "KayitBy",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "OdemeGun",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PostaKodu",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Sehir",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SehirAdi",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Semt",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Silindi",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Sirket",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SubeAdi",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SubeKodu",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "TCNo",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Tel1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Tel2",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Ulke",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Unvan",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "VadeGun",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "VergiDairesi",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "VergiNo",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Yetkili",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "YetkiliEmail",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "YetkiliTel1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "YetkiliTel2",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "kayitDate",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Customers",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Customers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "Country", "CustomerName", "Email", "IsDeleted", "Phone" },
                values: new object[] { 1, "", "Ankara", "Türkiye", "A Şirketi", "abc@hotmail.com", false, "11111111" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "Country", "CustomerName", "Email", "IsDeleted", "Phone" },
                values: new object[] { 2, "", "İtsanbul", "Türkiye", "B Şirketi", "def@hotmail.com", false, "2222222" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "Country", "CustomerName", "Email", "IsDeleted", "Phone" },
                values: new object[] { 3, "", "İzmir", "Türkiye", "C Şirketi", "xyz@hotmail.com", false, "33333333" });
        }
    }
}
