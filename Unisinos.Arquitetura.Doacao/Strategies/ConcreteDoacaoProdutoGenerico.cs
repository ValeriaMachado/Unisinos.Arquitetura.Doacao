using HelpSVP.Data.Repositories;
using HelpSVP.Models;
using HelpSVP.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpSVP.Strategies
{
    public class ConcreteDoacaoProdutoGenerico
    {
        private readonly DoacaoProdutoGenericoRepository _repository;

        public ConcreteDoacaoProdutoGenerico(DoacaoProdutoGenericoRepository repository)
        {
            _repository = repository;
        }

        public void EfetuarDoacao(EfetuarDoacaoRequest request)
        {
            if (!string.IsNullOrEmpty(request.Tamanho) && string.IsNullOrEmpty(request.Finalidade))
            {
                var doacaoProduto = new DoacaoProdutoGenerico()
                {
                    DataHora = request.DataHora,
                    Tamanho = request.Tamanho,
                    Finalidade = request.Finalidade
                };

                _repository.Add(doacaoProduto);
            }
        }
    }
}
