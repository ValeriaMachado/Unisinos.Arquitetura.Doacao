using HelpSVP.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HelpSVP.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<DoacaoProdutoConfeccionado> DoacaoProdutoConfeccionados { get; }

        public DbSet<DoacaoFinanceira> DoacaoFinanceira { get; }

        public DbSet<DoacaoAlimento> DoacaoAlimento { get; }

        public DbSet<DoacaoHigiene> DoacaoHigiene { get; }
        public DbSet<DoacaoMedicamento> DoacaoMedicamento { get; }

        public DbSet<DoacaoProdutoGenerico> DoacaoProdutoGenerico { get; }
        public DbSet<Morador> Morador { get; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Morador>(entity =>
            {
                entity.ToTable("morador");
            });
        }
    }
}
