using Microsoft.EntityFrameworkCore;

namespace MvcApplication1.Models
{
    public class EmpregadosContext : DbContext
    {
        public EmpregadosContext(DbContextOptions<EmpregadosContext> options) : base(options)
        {

        }

        public DbSet<Empregados> Empregados { get; set; }
    }
}
