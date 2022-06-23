using HelpSVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpSVP.Data.Repositories
{
    public class DoacaoProdutoConfeccionadoRepository
    {
        private readonly ApplicationDbContext _applicationDb;

        public DoacaoProdutoConfeccionadoRepository(ApplicationDbContext applicationDb)
        {
            _applicationDb = applicationDb;
        }

        public bool Add(DoacaoProdutoConfeccionado doacao)
        {
            _applicationDb.DoacaoProdutoConfeccionados.Add(doacao);

            return _applicationDb.SaveChanges() > 0;
        }
    }
}
