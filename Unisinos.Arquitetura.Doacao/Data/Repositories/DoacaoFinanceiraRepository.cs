using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelpSVP.Models;

namespace HelpSVP.Data.Repositories
{
    public class DoacaoFinanceiraRepository
    {
        private readonly ApplicationDbContext _applicationDb;

        public DoacaoFinanceiraRepository(ApplicationDbContext applicationDb)
        {
            _applicationDb = applicationDb;
        }

        public bool Add(DoacaoFinanceira doacao)
        {
            _applicationDb.DoacaoFinanceira.Add(doacao);

            return _applicationDb.SaveChanges() > 0;
        }
    }
}

