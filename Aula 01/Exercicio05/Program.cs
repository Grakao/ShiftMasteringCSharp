using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 05 *****/

            //Faça um algoritmo que leia uma temperatura em Fahrenheit e a apresente convertida em graus Celsius.
            //A fórmula de conversão é C = (F – 32) *(5 / 9), na qual F é a temperatura em Fahrenheit e C é a temperatura em Celsius.

            Console.WriteLine("*** Exercício 04 - Ler temperatura em Fahrenheit e exibir a conversão para Celsius ***");

            Console.WriteLine("Digite a temperatura em Fahrenheit: ");
            var tempF = Convert.ToDouble(Console.ReadLine());

            var tempC = (tempF - 32) * 5 / 9;
            Console.WriteLine("A temperatura em Celsius é: " + tempC);
        }
    }
}