using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemaSeguro.Entities
{
    public class Seguro
    {
        public Seguro()
        {
            Pessoa pessoa = new Pessoa();
        }

        #region Propriedades
        public double ValorAutomovel { get; set; }

        public Pessoa Pessoa { get; set; }
        #endregion

        #region Métodos
        public double CalcularSeguro()
        {
            double valorSeguro;

            if (Pessoa.Sexo == Enums.SexoEnum.M)
            {
                if (Pessoa.Idade < 24)
                {
                    valorSeguro = ValorAutomovel * 0.2;
                }
                else
                {
                    valorSeguro = ValorAutomovel * 0.1;
                }
            }
            else
            {
                valorSeguro = ValorAutomovel * 0.05;
            }

            return valorSeguro;
        }
        #endregion
    }
}