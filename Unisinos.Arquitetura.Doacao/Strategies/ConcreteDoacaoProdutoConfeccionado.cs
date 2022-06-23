using HelpSVP.Data.Repositories;
using HelpSVP.Models;
using HelpSVP.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpSVP.Strategies
{
    public class ConcreteDoacaoProdutoConfeccionado : IDoacao
    {
        private readonly DoacaoProdutoConfeccionadoRepository _repository;

        public ConcreteDoacaoProdutoConfeccionado(DoacaoProdutoConfeccionadoRepository repository)
        {
            _repository = repository;
        }

        public void EfetuarDoacao(EfetuarDoacaoRequest request)
        {
            if (request.Valor.HasValue)
            {
                var doacaoProduto = new DoacaoProdutoConfeccionado()
                {
                    DataHora = request.DataHora,
                    Imagem = request.Imagem,
                    Valor = request.Valor.Value
                };

                _repository.Add(doacaoProduto);
            }
        }
    }
}
