using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Investimentos.API.Data;
using Investimentos.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Investimentos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransacaoController : ControllerBase
    {
        private readonly DataContext _context;

        public TransacaoController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public IEnumerable<Transacao> Get()
        {
            return _context.Transacoes;
        }

        [HttpGet("{id}")]
        public Transacao GetById(int id)
        {
            return _context.Transacoes.FirstOrDefault(t => t.Id == id);
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
