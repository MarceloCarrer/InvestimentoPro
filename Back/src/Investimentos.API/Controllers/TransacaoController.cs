using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Investimentos.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Investimentos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransacaoController : ControllerBase
    {
        public IEnumerable<Transacao> _transacao = new Transacao[] {
            new Transacao(){
                Id = 1,
                DataCompra = DateTime.Now.AddDays(2),
                ValorCompra = 2.50,
                QuantidadeCompra = 11,
                TotalValorCompra = 2.50 * 11,
                IdAtivo = 1,
                IdTipoAtivo = 1
            },
            new Transacao(){
                Id = 2,
                DataCompra = DateTime.Now.AddDays(5),
                ValorCompra = 6.50,
                QuantidadeCompra = 35,
                TotalValorCompra = 6.50 * 35,
                IdAtivo = 2,
                IdTipoAtivo = 1
            }
        };
        
        public TransacaoController()
        {
           
        }

        [HttpGet]
        public IEnumerable<Transacao> Get()
        {
            return _transacao;
        }

        [HttpGet("{id}")]
        public IEnumerable<Transacao> GetById(int id)
        {
            return _transacao.Where(t => t.Id == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo Delete com id = {id}";
        }

        
    }
}
