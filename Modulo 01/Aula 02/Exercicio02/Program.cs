using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 02 *****/

            // Faça um algoritmo que leia os valores A, B e C. Mostre uma mensagem que informe se a soma de A com B é menor, maior ou igual a C.

            Console.WriteLine("*** Exercício 02 - Mostrar soma de valores com desvio condicional ***");

            double valorA, valorB, valorC, soma;

            Console.WriteLine("Digite o valor de A: ");
            valorA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            valorB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de C: ");
            valorC = Convert.ToDouble(Console.ReadLine());

            soma = valorA + valorB;

            if (soma > valorC)
            {
                Console.WriteLine("A soma de A + B é maior do que o valor de C.");
            }
            else if (soma < valorC)
            {
                Console.WriteLine("A soma de A + B é menor do que o valor de C.");
            }
            else if (soma == valorC)
            {
                Console.WriteLine("A soma de A + B é igual ao valor de C.");
            }
        }
    }
}
