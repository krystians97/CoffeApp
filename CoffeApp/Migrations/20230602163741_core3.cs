using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeApp.Migrations
{
    public partial class core3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2401a98-d7f6-4f96-87cd-31b80278ab97", "AQAAAAEAACcQAAAAEMc21/ERk60neg1znxL9fUnijqiPah5148zCKDbIOaKAJq+mFcGKIx6MbOnq0rgJyw==", "b2b47217-be5c-4941-b4fb-67dc56421299" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8cd174c-b431-49bf-98f4-47cfab5255df", "AQAAAAEAACcQAAAAEIULVocut55uIz/hLPI0OtqqrYtzYpaIZpsjGLTo2W5nyg9IITOIIqQZQXne+x4euQ==", "2b778db9-104f-4f22-9aab-9e929333add0" });
        }
    }
}
