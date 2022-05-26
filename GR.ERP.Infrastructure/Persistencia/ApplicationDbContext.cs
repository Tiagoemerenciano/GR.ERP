using GR.ERP.Application.Interfaces;
using GR.ERP.Domain.Funcionario;
using Microsoft.EntityFrameworkCore;

namespace GR.ERP.Infraestrutura.Persistencia
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Funcionario> Empregados { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
    }
}
