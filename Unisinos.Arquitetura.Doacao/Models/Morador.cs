using System;

namespace HelpSVP.Models
{
    public class Morador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Naturalidade { get; set; }
        public string Pais { get; set; }
        public string UF { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string ContatoEmergencia { get; set; }
        public int TelefoneEmergencia { get; set; }
        public string DoencaAlergica { get; set; }
        public double Valor { get; set; }
        public DateTime DataHoraCadastro { get; set; }

    }
}
