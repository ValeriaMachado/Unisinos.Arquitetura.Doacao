using HelpSVP.Requests;
using System;

namespace HelpSVP.Strategies
{
    public interface IDoacao
    {
        void EfetuarDoacao(EfetuarDoacaoRequest request);
    }
}
