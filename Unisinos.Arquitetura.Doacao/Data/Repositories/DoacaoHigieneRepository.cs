using HelpSVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpSVP.Data.Repositories
{
    public class DoacaoHigieneRepository
    {
        private readonly ApplicationDbContext _applicationDb;

        public DoacaoHigieneRepository(ApplicationDbContext applicationDb)
        {
            _applicationDb = applicationDb;
        }

        public bool Add(DoacaoHigiene doacao)
        {
            _applicationDb.DoacaoHigiene.Add(doacao);

            return _applicationDb.SaveChanges() > 0;
        }
    }
}
