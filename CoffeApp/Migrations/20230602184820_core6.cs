using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeApp.Migrations
{
    public partial class core6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3ac5367-20ce-4449-a98a-0d1b98dbfb87", "AQAAAAEAACcQAAAAEEarasgDgvQGefiThg/zh+DXQG0uVNYgyBid41+kUKtHoDoBp2y4HyoZzFlOSQSthA==", "a9f00787-2407-4800-8a1d-472f7b65c627" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5743eaac-00a0-4834-bb44-6e30995931ad", "AQAAAAEAACcQAAAAEAsmsRHmXMnPDj/uWqlC1A/ajRK2M1YcqzvB8+1dco7lveIO98HYJn+5pvazoOIkFA==", "98994572-e452-4f46-820e-0ff11ad065e7" });
        }
    }
}
