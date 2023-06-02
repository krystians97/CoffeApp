using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeApp.Migrations
{
    public partial class core2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8cd174c-b431-49bf-98f4-47cfab5255df", "AQAAAAEAACcQAAAAEIULVocut55uIz/hLPI0OtqqrYtzYpaIZpsjGLTo2W5nyg9IITOIIqQZQXne+x4euQ==", "2b778db9-104f-4f22-9aab-9e929333add0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c05ba973-80c9-49e8-85c8-537a438b88c8", "AQAAAAEAACcQAAAAECr+DLdDKawFeDE+NpgJ93n/E0X/Q7qR1IvZ9XbtjQT4UPtc+PajvTCbyWqzrta2hg==", "9231ad3b-17e8-48a6-a232-2be1cfc2b18f" });
        }
    }
}
