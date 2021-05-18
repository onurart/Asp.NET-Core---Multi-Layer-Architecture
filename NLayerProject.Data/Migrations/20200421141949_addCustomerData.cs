using Microsoft.EntityFrameworkCore.Migrations;

namespace NLayerProject.Data.Migrations
{
    public partial class addCustomerData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
