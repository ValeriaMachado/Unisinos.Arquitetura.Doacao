using HelpSVP.Data.Repositories;
using HelpSVP.Models;
using HelpSVP.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpSVP.Strategies
{
    public class ConcreteDoacaoHigiene :IDoacao
    {
        private readonly DoacaoHigieneRepository _repository;

        public ConcreteDoacaoHigiene(DoacaoHigieneRepository repository)
        {
            _repository = repository;
        }

        public void EfetuarDoacao(EfetuarDoacaoRequest request)
        {
            if (request.Validade.HasValue)
            {
                var doacaoProduto = new DoacaoHigiene()
                {
                    DataHora = request.DataHora,
                    Validade = request.Validade.Value,
                };

                _repository.Add(doacaoProduto);
            }
        }
    }
}

