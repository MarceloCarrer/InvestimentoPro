using System;

namespace Investimentos.API.Models
{
    public class Transacao
    {
        public int Id { get; set; }

        public DateTime DataCompra { get; set; }

        public double ValorCompra { get; set; }

        public int QuantidadeCompra { get; set; }

        public double TotalValorCompra { get; set; }

        public DateTime? DataVenda { get; set; }

        public double? ValorVenda { get; set; }

        public int? QuantidadeVenda { get; set; }

        public double? ValorTotalVenda { get; set; }

        public double? Lucro { get; set; }

        public double? ValorLucro { get; set; }

        public double? ValorImposto { get; set; }

        public double? ValorLucroLiquido { get; set; }

        public double? ValorVendaLiquida { get; set; }

        public int IdAtivo { get; set; }

        public int IdTipoAtivo { get; set; }
    }
}