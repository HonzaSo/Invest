using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Invest.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddFinancialProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FinancialProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Symbol = table.Column<string>(type: "text", nullable: false),
                    From = table.Column<string>(type: "text", nullable: false),
                    Open = table.Column<double>(type: "double precision", nullable: false),
                    High = table.Column<double>(type: "double precision", nullable: false),
                    Low = table.Column<double>(type: "double precision", nullable: false),
                    Close = table.Column<double>(type: "double precision", nullable: false),
                    Volume = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialProducts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FinancialProducts",
                columns: new[] { "Id", "Close", "From", "High", "Low", "Open", "Symbol", "Volume" },
                values: new object[,]
                {
                    { 1, 150.87, "2023-09-01", 154.33000000000001, 150.41999999999999, 153.77500000000001, "T", 123456L },
                    { 2, 150.87, "2023-09-01", 154.33000000000001, 150.41999999999999, 153.77500000000001, "E", 123456L },
                    { 3, 150.87, "2023-09-01", 154.33000000000001, 150.41999999999999, 153.77500000000001, "S", 123456L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FinancialProducts");
        }
    }
}
