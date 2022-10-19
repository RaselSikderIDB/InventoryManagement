using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryBeginners.Migrations
{
    public partial class AddSelfForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Currencies_Currencies_CurrenciesId",
                table: "Currencies");

            migrationBuilder.RenameColumn(
                name: "CurrenciesId",
                table: "Currencies",
                newName: "ExchangeCurrencyId");

            migrationBuilder.RenameIndex(
                name: "IX_Currencies_CurrenciesId",
                table: "Currencies",
                newName: "IX_Currencies_ExchangeCurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Currencies_Currencies_ExchangeCurrencyId",
                table: "Currencies",
                column: "ExchangeCurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Currencies_Currencies_ExchangeCurrencyId",
                table: "Currencies");

            migrationBuilder.RenameColumn(
                name: "ExchangeCurrencyId",
                table: "Currencies",
                newName: "CurrenciesId");

            migrationBuilder.RenameIndex(
                name: "IX_Currencies_ExchangeCurrencyId",
                table: "Currencies",
                newName: "IX_Currencies_CurrenciesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Currencies_Currencies_CurrenciesId",
                table: "Currencies",
                column: "CurrenciesId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
