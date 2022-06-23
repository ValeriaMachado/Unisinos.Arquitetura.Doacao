using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpSVP.Models
{
    public class DoacaoProdutoGenerico : BaseDoacao
    {
        public string Tamanho { get; set; }

        public string Finalidade { get; set; }
    }
}
