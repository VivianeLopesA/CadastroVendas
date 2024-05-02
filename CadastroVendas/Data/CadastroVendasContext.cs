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

        public DbSet<CadastroVendas.Models.ADM> ADM { get; set; } = default!;
        public DbSet<CadastroVendas.Models.Produto> Produto { get; set; } = default!;
        public DbSet<CadastroVendas.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<CadastroVendas.Models.Funcionario> Funcionario { get; set; } = default!;
    }
}
