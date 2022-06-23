using HelpSVP.Data.Repositories;
using HelpSVP.Models;
using HelpSVP.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpSVP.Strategies
{
    public class ConcreteDoacaoAlimento
    {
        private readonly DoacaoAlimentoRepository _repository;

        public ConcreteDoacaoAlimento(DoacaoAlimentoRepository repository)
        {
            _repository = repository;
        }

        public void EfetuarDoacao(EfetuarDoacaoRequest request)
        {
            if (request.Validade.HasValue && !string.IsNullOrEmpty(request.TipoEmbalagem))
            {
                var doacaoProduto = new DoacaoAlimento()
                {
                    DataHora = request.DataHora,
                    Validade = request.Validade.Value,
                    TipoEmbalagem = request.TipoEmbalagem,
                };

                _repository.Add(doacaoProduto);
            }
        }
    }
}
