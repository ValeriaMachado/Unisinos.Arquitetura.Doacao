using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpSVP.Models
{
    public class DoacaoMedicamento : BaseDoacao
    {
        public DateTime Validade { get; set; }
        public string TipoEmbalagem { get; set; }

        public string Descricao { get; set; }

        public string NomeQuimico { get; set; }

    }
}
