using HelpSVP.Data.Repositories;
using HelpSVP.Models;
using HelpSVP.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpSVP.Strategies
{
    public class ConcreteDoacaoMedicamento
    {
            private readonly DoacaoMedicamentoRepository _repository;

            public ConcreteDoacaoMedicamento(DoacaoMedicamentoRepository repository)
            {
                _repository = repository;
            }

            public void EfetuarDoacao(EfetuarDoacaoRequest request)
            {
                if (request.Validade.HasValue && !string.IsNullOrEmpty(request.TipoEmbalagem))
                {
                    var doacaoProduto = new DoacaoMedicamento()
                    {
                        DataHora = request.DataHora,
                        Validade = request.Validade.Value,
                        TipoEmbalagem = request.TipoEmbalagem,
                        NomeQuimico = request.NomeQuimico,
                        Descricao = request.Descricao,
                    };

                    _repository.Add(doacaoProduto);
                }
            }
        }
    }


