using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 04 *****/

            // Escrever um algoritmo para ler dois valores numéricos e apresentar a diferença do maior pelo menor.

            Console.WriteLine("*** Exercício 04 - Ler dois valores e apresentar a diferença ***");

            double valor1, valor2, diferenca;

            Console.WriteLine("Digite o primeiro valor:");
            valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            valor2 = Convert.ToDouble(Console.ReadLine());

            if (valor1 > valor2)
            {
                diferenca = valor1 - valor2;
                Console.WriteLine("O primeiro valor é maior e diferença entre eles é de: " + diferenca + ".");
            }
            else if (valor1 < valor2)
            {
                diferenca = valor2 - valor1;
                Console.WriteLine("O primeiro valor é menor e diferença entre eles é de: " + diferenca + ".");
            }
            else
            {
                Console.WriteLine("Os valores são iguais.");
            }
        }
    }
}
