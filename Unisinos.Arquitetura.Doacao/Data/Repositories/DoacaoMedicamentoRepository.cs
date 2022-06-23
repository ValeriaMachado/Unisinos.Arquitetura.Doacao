using HelpSVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpSVP.Data.Repositories
{
    public class DoacaoMedicamentoRepository
    {
        private readonly ApplicationDbContext _applicationDb;

        public DoacaoMedicamentoRepository(ApplicationDbContext applicationDb)
        {
            _applicationDb = applicationDb;
        }

        public bool Add(DoacaoMedicamento doacao)
        {
            _applicationDb.DoacaoMedicamento.Add(doacao);

            return _applicationDb.SaveChanges() > 0;
        }
    }
}
