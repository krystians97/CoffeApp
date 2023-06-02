using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeApp.Migrations
{
    public partial class core5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5743eaac-00a0-4834-bb44-6e30995931ad", "AQAAAAEAACcQAAAAEAsmsRHmXMnPDj/uWqlC1A/ajRK2M1YcqzvB8+1dco7lveIO98HYJn+5pvazoOIkFA==", "98994572-e452-4f46-820e-0ff11ad065e7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34646a76-a50f-46d1-b077-83432f33191f", "AQAAAAEAACcQAAAAEC0kfFd/8NniNV7JTr8zDe7ILEWpDoScw/llz4DX3b9QcUG2+rZSrYg6efNeKMIamw==", "7fda2aae-29ce-4030-9b47-f30165a1ada4" });
        }
    }
}
