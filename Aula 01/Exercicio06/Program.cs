using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 06 *****/

            //Faça um algoritmo que calcule e apresente o valor do volume de uma lata de óleo, utilizando a fórmula VOLUME = 3,14159 * RAIO2 * ALTURA

            Console.WriteLine("*** Exercício 06 - Cálculo do volume de uma lata de óleo ***");

            Console.WriteLine("Digite o valor do raio da lata: ");
            var raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura da lata: ");
            var altura = Convert.ToDouble(Console.ReadLine());

            var volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine("Volume de uma lata de óleo: " + volume);
        }
    }
}
