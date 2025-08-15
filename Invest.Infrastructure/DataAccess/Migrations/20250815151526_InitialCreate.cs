using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invest.Infrastructure.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FinancialProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAccounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    FinancialProductId = table.Column<Guid>(type: "uuid", nullable: true),
                    PurchaseDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Quantity = table.Column<decimal>(type: "numeric", nullable: true),
                    PurchasePrice = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAccounts_FinancialProducts_FinancialProductId",
                        column: x => x.FinancialProductId,
                        principalTable: "FinancialProducts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserAccounts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserAccounts_FinancialProductId",
                table: "UserAccounts",
                column: "FinancialProductId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccounts_UserId",
                table: "UserAccounts",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAccounts");

            migrationBuilder.DropTable(
                name: "FinancialProducts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
