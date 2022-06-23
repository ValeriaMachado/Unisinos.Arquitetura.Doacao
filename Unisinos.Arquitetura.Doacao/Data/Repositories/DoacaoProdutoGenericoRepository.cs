using HelpSVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpSVP.Data.Repositories
{
    public class DoacaoProdutoGenericoRepository
    {
        private readonly ApplicationDbContext _applicationDb;

        public DoacaoProdutoGenericoRepository(ApplicationDbContext applicationDb)
        {
            _applicationDb = applicationDb;
        }

        public bool Add(DoacaoProdutoGenerico doacao)
        {
            _applicationDb.DoacaoProdutoGenerico.Add(doacao);

            return _applicationDb.SaveChanges() > 0;
        }
    }
}
