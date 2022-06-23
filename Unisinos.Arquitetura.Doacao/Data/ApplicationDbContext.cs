using HelpSVP.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HelpSVP.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<DoacaoProdutoConfeccionado> DoacaoProdutoConfeccionados { get; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
