using GR.ERP.Domain.Funcionario;
using Microsoft.EntityFrameworkCore;

namespace GR.ERP.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Funcionario> Empregados { get; set; }
        Task<int> SaveChangesAsync();
    }
}
