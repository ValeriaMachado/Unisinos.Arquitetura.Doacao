using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpSVP.Models
{
    public class DoacaoAlimento : BaseDoacao
    {
        public DateTime Validade { get; set; }

        public string TipoEmbalagem { get; set; }
    }
}
