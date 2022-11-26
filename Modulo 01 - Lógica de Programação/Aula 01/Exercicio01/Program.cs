using System;

namespace CadernoDeExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 01 *****/

            //Faça um algoritmo para calcular a área de uma circunferência, considerando a fórmula ÁREA = π * RAIO2
            //Utilize as variáveis AREA e RAIO, a constante π(pi = 3,14159) e os operadores aritméticos de multiplicação.

            Console.WriteLine("*** Exercício 01 - Calcular a área de uma circunferência ***");
            
            Console.WriteLine("Digite o valor do raio: ");
            var raio = Convert.ToDouble(Console.ReadLine());

            var area = Math.Pow(raio,2) * Math.PI;
            Console.WriteLine("O valor da área é: " + area);
        }
    }
}
