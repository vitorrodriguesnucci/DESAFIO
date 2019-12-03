using System;
using System.Collections.Generic;
using System.Text;

namespace ex03
{
    public class Fornecedor : IComparable<Fornecedor>
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Email { get; set; }

        public int CompareTo(Fornecedor dados)
        {
            return this.Nome.CompareTo(dados.Nome);
        }
    }
}
