using Investimentos.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Investimentos.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        
        public DbSet<Transacao> Transacoes { get; set; }
    }
}