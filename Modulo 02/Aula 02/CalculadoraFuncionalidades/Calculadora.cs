using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraFuncionalidades
{
    public class Calculadora
    {
        #region Propriedades
        public int ValorA { get; set; }

        public int ValorB { get; set; }

        public char Op { get; set; }
        #endregion

        #region Métodos
        public bool TestaValor(int valor)
        {
            if (valor == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool TestaOperador()
        {
            switch (Op)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                    return true;
                default:
                    Console.WriteLine("Operador inválido.");
                    return false;
            }
        }

        public int Calcular()
        {
            switch (Op)
            {
                case '+':
                    return ValorA + ValorB;
                case '-':
                    return ValorA - ValorB;
                case '*':
                    return ValorA * ValorB;
                case '/':
                    return ValorA / ValorB;
                default:
                    return 0;
            }
        }

        public string ExibirResultado()
        {
            return "Resultado: " + Calcular().ToString();
        }
        #endregion




    }
}
