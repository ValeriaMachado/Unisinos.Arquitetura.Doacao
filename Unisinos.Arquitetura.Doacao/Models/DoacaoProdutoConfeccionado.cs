using HelpSVP.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpSVP.Models
{
    public class DoacaoProdutoConfeccionado : BaseDoacao
    {
        public double Valor { get; set; }
        public string Imagem { get; set; }
    }
}
