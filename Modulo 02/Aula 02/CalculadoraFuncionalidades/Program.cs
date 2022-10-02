using System;

namespace CalculadoraFuncionalidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.WriteLine("Digite o Valor de A: ");
            var valor = Convert.ToInt32(Console.ReadLine());

            if (!calc.TestaValor(valor))
            {
                Console.WriteLine("Valor inválido.");
                return;
            }
            else
            {
                calc.ValorA = valor;
            }

            Console.WriteLine("Digite o Valor de B: ");
            valor = Convert.ToInt32(Console.ReadLine());

            if (!calc.TestaValor(valor))
            {
                Console.WriteLine("Valor inválido.");
                return;
            }
            else
            {
                calc.ValorB = valor;
            }

            Console.WriteLine("Digite a operação aritmética desejada: ");
            calc.Op = Convert.ToChar(Console.ReadLine());

            if (calc.TestaOperador())
            {
                calc.Calcular();
                Console.WriteLine(calc.ExibirResultado());
            }
            else
            {
                Console.WriteLine("Operador inválido.");
                return;
            }
        }
    }
}
