using HelpSVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpSVP.Data.Repositories
{
    public class DoacaoAlimentoRepository
    {
        private readonly ApplicationDbContext _applicationDb;

        public DoacaoAlimentoRepository(ApplicationDbContext applicationDb)
        {
            _applicationDb = applicationDb;
        }

        public bool Add(DoacaoAlimento doacao)
        {
            _applicationDb.DoacaoFinanceira.Add(doacao);

            return _applicationDb.SaveChanges() > 0;
        }
    }
}
