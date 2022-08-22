using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 01 *****/

            //Construa um algoritmo que receba como entrada três valores e os imprima em ordem crescente.

            Console.WriteLine("*** Exercício 01 - Impressão de valores em ordem crescente ***");

            double valor1, valor2, valor3;

            Console.WriteLine("Digite o primeiro valor:");
            valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor:");
            valor3 = Convert.ToDouble(Console.ReadLine());

            if (valor1 < valor2 && valor1 < valor3)
            {
                if (valor2 < valor3)
                {
                    Console.WriteLine("Ordem: " + valor1 + "," + valor2 + "," + valor3);
                }
                else
                {
                    Console.WriteLine("Ordem: " + valor1 + "," + valor3 + "," + valor2);
                }
            }
            else if (valor2 < valor1 && valor2 < valor3)
            {
                if (valor1 < 3)
                {
                    Console.WriteLine("Ordem: " + valor2 + "," + valor1 + "," + valor3);
                }
                else
                {
                    Console.WriteLine("Ordem: " + valor2 + "," + valor3 + "," + valor1);
                }
            }
            else if (valor3 < valor1 && valor3 < valor2)
            {
                if (valor2 < valor1)
                {
                    Console.WriteLine("Ordem: " + valor3 + "," + valor2 + "," + valor1);
                }
                else
                {
                    Console.WriteLine("Ordem: " + valor3 + "," + valor1 + "," + valor2);
                }
            }
            else
            {
                Console.WriteLine("Ordem: " + valor3 + "," + valor1 + "," + valor2 + " - igualdade encontrada.");
            }
        }
    }
}
