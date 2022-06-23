using HelpSVP.Data.Repositories;
using HelpSVP.Models;
using HelpSVP.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpSVP.Strategies
{
    public class ConcreteDoacaoFinanceira
    {
        private readonly DoacaoFinanceiraRepository _repository;

        public ConcreteDoacaoFinanceira(DoacaoFinanceiraRepository repository)
        {
            _repository = repository;
        }

        public void EfetuarDoacao(EfetuarDoacaoRequest request)
        {
            if (request.Valor.HasValue && !string.IsNullOrEmpty(request.Moeda))
            {
                var doacaoProduto = new DoacaoFinanceira()
                {
                    DataHora = request.DataHora,
                    Valor = request.Valor.Value,
                    Moeda = request.Moeda,
                };

                _repository.Add(doacaoProduto);
            }
        }
    }
}
