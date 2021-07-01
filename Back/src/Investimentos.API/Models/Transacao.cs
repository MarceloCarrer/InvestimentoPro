using System;

namespace Investimentos.API.Models
{
    public class Transacao
    {
        public int Id { get; set; }

        public DateTime DataCompra { get; set; }

        public decimal ValorCompra { get; set; }

        public int QuantidadeCompra { get; set; }

        public decimal TotalValorCompra { get; set; }

        public DateTime? DataVenda { get; set; }

        public decimal? ValorVenda { get; set; }

        public int? QuantidadeVenda { get; set; }

        public decimal? ValorTotalVenda { get; set; }

        public decimal? Lucro { get; set; }

        public decimal? ValorLucro { get; set; }

        public decimal? ValorImposto { get; set; }

        public decimal? ValorLucroLiquido { get; set; }

        public decimal? ValorVendaLiquida { get; set; }

        public int IdAtivo { get; set; }

        public int IdTipoAtivo { get; set; }
    }
}