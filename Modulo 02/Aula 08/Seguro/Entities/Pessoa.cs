using ProblemaSeguro.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemaSeguro.Entities
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public SexoEnum Sexo { get; set; }
    }
}
