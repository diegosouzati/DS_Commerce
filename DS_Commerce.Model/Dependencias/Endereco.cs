using System;
using System.Collections.Generic;
using System.Text;

namespace DS_Commerce.Model.Dependencias
{
    public class Endereco
    {
        public string Cep { get; set; }

        public string Logradouro { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }
    }
}
