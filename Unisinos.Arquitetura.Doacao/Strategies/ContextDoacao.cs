using HelpSVP.Models;
using HelpSVP.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpSVP.Strategies
{
    public class ContextDoacao
    {
        private IDoacao _doacao;

        public ContextDoacao(IDoacao doacao)
        {
            _doacao = doacao;
        }

        public void EfetuaDoacao(EfetuarDoacaoRequest request)
        {
            _doacao.EfetuarDoacao(request);
        }
    }
}
