using HelpSVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpSVP.Data.Repositories
{
    public class MoradorRepository
    {
        private readonly ApplicationDbContext _applicationDb;

        public MoradorRepository(ApplicationDbContext applicationDb)
        {
            _applicationDb = applicationDb;
        }

        public bool Add(Morador morador)
        {
            _applicationDb.Morador.Add(morador);

            return _applicationDb.SaveChanges() > 0;
        }
    }
}
