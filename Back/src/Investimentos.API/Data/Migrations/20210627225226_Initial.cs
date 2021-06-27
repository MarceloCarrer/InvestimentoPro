using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Investimentos.API.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataCompra = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ValorCompra = table.Column<double>(type: "REAL", nullable: false),
                    QuantidadeCompra = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalValorCompra = table.Column<double>(type: "REAL", nullable: false),
                    DataVenda = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ValorVenda = table.Column<double>(type: "REAL", nullable: true),
                    QuantidadeVenda = table.Column<int>(type: "INTEGER", nullable: true),
                    ValorTotalVenda = table.Column<double>(type: "REAL", nullable: true),
                    Lucro = table.Column<double>(type: "REAL", nullable: true),
                    ValorLucro = table.Column<double>(type: "REAL", nullable: true),
                    ValorImposto = table.Column<double>(type: "REAL", nullable: true),
                    ValorLucroLiquido = table.Column<double>(type: "REAL", nullable: true),
                    ValorVendaLiquida = table.Column<double>(type: "REAL", nullable: true),
                    IdAtivo = table.Column<int>(type: "INTEGER", nullable: false),
                    IdTipoAtivo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transacoes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transacoes");
        }
    }
}
