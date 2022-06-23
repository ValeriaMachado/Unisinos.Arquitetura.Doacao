using System;

namespace HelpSVP.Requests
{
    public class EfetuarDoacaoRequest
    {
        public DateTime DataHora { get; set; }
        public DateTime? Validade { get; set; }
        public string TipoEmbalagem { get; set; }
        public string NomeQuimico { get; set; }
        public string Descricao { get; set; }
        public string Finalidade { get; set; }
        public double? Valor { get; set; }
        public string Imagem { get; set; }
    }
}
