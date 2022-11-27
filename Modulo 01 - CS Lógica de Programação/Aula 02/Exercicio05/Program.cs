using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 05 *****/

            // Escrever um algoritmo para ler dois números. Se os números forem iguais imprimir a mensagem: “Números iguais” e encerrar a execução.
            // Caso contrário, imprimir o de maior valor, acompanhando pela mensagem “é maior número”

            Console.WriteLine("*** Exercício 05 - Ler dois números e exibir uma mensagem de acordo com a condição ***");

            double valor1, valor2;

            Console.WriteLine("Digite o primeiro valor:");
            valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            valor2 = Convert.ToDouble(Console.ReadLine());

            if (valor1 == valor2)
            {
                Console.WriteLine("Os números são iguais.");
            }
            else
            {
                if (valor1 > valor2)
                {
                    Console.WriteLine("Números diferentes. O maior deles é: " + valor1 + ".");
                }
                else
                {
                    Console.WriteLine("Números diferentes. O maior deles é: " + valor2 + ".");
                }   
            }
        }
    }
}
