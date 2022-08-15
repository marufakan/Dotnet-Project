using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace DataApi.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    CurrencyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    Isim = table.Column<string>(type: "text", nullable: true),
                    CurrencyName = table.Column<string>(type: "text", nullable: true),
                    ForexBuying = table.Column<string>(type: "text", nullable: true),
                    ForexSelling = table.Column<string>(type: "text", nullable: true),
                    BanknoteBuying = table.Column<string>(type: "text", nullable: true),
                    BanknoteSelling = table.Column<string>(type: "text", nullable: true),
                    CrossRateUSD = table.Column<string>(type: "text", nullable: true),
                    CrossRateOther = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.CurrencyID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Currencies");
        }
    }
}
