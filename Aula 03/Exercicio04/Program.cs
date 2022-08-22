using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 04 *****/

            //Faça um algoritmo que leia 3 números inteiros distintos e escreva o menor deles.

            Console.WriteLine("*** Exercício 04 - Exibir o menor de três números ***");

            int valor1, valor2, valor3;

            Console.WriteLine("Digite o primeiro número inteiro:");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro:");
            valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número inteiro:");
            valor3 = Convert.ToInt32(Console.ReadLine());

            if (valor1 < valor2 && valor1 < valor3)
            {
                Console.WriteLine("O primeiro número é o menor. Valor: " + valor1);
            }
            else if (valor2 < valor1 && valor2 < valor3)
            {
                Console.WriteLine("O segundo número é o menor. Valor: " + valor2);
            }
            else if (valor3 < valor1 && valor3 < valor2)
            {
                Console.WriteLine("O terceiro número é o menor. Valor: " + valor3);
            }
            else if (valor1 == valor2 || valor1 == valor3 || valor2 == valor3)
            {
                Console.WriteLine("Números iguais detectados.");
            }
        }
    }
}
