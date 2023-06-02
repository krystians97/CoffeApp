using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeApp.Migrations
{
    public partial class core4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34646a76-a50f-46d1-b077-83432f33191f", "AQAAAAEAACcQAAAAEC0kfFd/8NniNV7JTr8zDe7ILEWpDoScw/llz4DX3b9QcUG2+rZSrYg6efNeKMIamw==", "7fda2aae-29ce-4030-9b47-f30165a1ada4" });

            migrationBuilder.CreateIndex(
                name: "IX_Order_OfferId",
                table: "Order",
                column: "OfferId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Offer_OfferId",
                table: "Order",
                column: "OfferId",
                principalTable: "Offer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Offer_OfferId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_OfferId",
                table: "Order");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2401a98-d7f6-4f96-87cd-31b80278ab97", "AQAAAAEAACcQAAAAEMc21/ERk60neg1znxL9fUnijqiPah5148zCKDbIOaKAJq+mFcGKIx6MbOnq0rgJyw==", "b2b47217-be5c-4941-b4fb-67dc56421299" });
        }
    }
}
