using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 04 *****/

            //Faça um algoritmo que leia uma temperatura em graus Celsius e apresente-a convertida em graus Fahrenheit.
            //A fórmula de conversão é: F = (9 * C + 160) / 5, na qual F é a temperatura em Fahrenheit e C é a temperatura em Celsius.

            Console.WriteLine("*** Exercício 04 - Ler temperatura em Celsius e exibir a conversão para Fahrenheit ***");

            Console.WriteLine("Digite a temperatura em Celsius: ");
            var tempC = Convert.ToDouble(Console.ReadLine());

            var tempF = (9 * tempC + 160) / 5;
            Console.WriteLine("A temperatura em Fahrenheit é: " + tempF);
        }
    }
}
