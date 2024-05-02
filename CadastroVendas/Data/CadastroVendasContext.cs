using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadastroVendas.Models;

namespace CadastroVendas.Data
{
    public class CadastroVendasContext : DbContext
    {
        public CadastroVendasContext (DbContextOptions<CadastroVendasContext> options)
            : base(options)
        {
        }

        public DbSet<CadastroVendas.Models.Usuario> ADM { get; set; } = default!;
        public DbSet<CadastroVendas.Models.Produto> Produto { get; set; } = default!;
        public DbSet<CadastroVendas.Models.Venda> Venda { get; set; } = default!;
    }
}
