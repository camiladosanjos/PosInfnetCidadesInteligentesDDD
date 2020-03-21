using Microsoft.EntityFrameworkCore;
using PosInfnetCidadesInteligentesDDD.Dominio.Entidades;

namespace PosInfnetCidadesInteligentesDDD.Infra.Dados.Config
{
    public class EstacaoRecargaDbContext : DbContext
    {
        public DbSet<EstacaoRecarga> EstacaoRecarga { get; set; }

        public EstacaoRecargaDbContext()
        {

        }

        public EstacaoRecargaDbContext(DbContextOptions<EstacaoRecargaDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetConnectionString());

            base.OnConfiguring(optionsBuilder);
        }

        private string GetConnectionString()
        {
            return
                "Server=(localdb)\\MSSQLLocalDB;Database=CidadesInteligentesDDD;Trusted_Connection=True;MultipleActiveResultSets=True;";
        }
    }
}
