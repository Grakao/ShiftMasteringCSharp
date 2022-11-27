using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 03 *****/

            //Sem utilizar a operação de multiplicação, escreva um programa que multiplique dois números inteiros.

            Console.WriteLine("*** Exercício 03 - Resultado de uma multiplicação sem o operador de multiplicação ***");

            int valor1, valor2, resultado = 0;

            Console.WriteLine("Digite o primeiro número inteiro: ");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro: ");
            valor2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= valor2; i++)
            {
                resultado += valor1;
            }

            Console.WriteLine("Resultado: " + resultado.ToString());
        }
    }
}
