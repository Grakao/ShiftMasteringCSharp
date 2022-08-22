using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 03 *****/

            // Crie um algoritmo que calcula o desconto previdenciário de um funcionário. Dado um salário, o programa deve retornar o valor do desconto proporcional ao mesmo.
            // O cálculo segue a regra: o desconto é de 11 % do valor do salário, entretanto, o valor máximo de desconto é 720,00.
            // Sendo assim, ou o algoritmo retorna o valor equivalente a 11 % sobre o salário ou 720,00

            Console.WriteLine("*** Exercício 03 - Cálculo do desconto previdenciário de um funcionário ***");

            double salario, desconto, salarioDescontado;

            Console.WriteLine("Digite o valor do salário: ");
            salario = Convert.ToDouble(Console.ReadLine());
            desconto = ((double)11 / 100);
            salarioDescontado = salario * desconto;

            if (salarioDescontado > 720)
            {
                Console.WriteLine("O valor do desconto é de 720 reais.");
            }
            else
            {
                Console.WriteLine("O valor do desconto é de " + salarioDescontado + " reais.");
            }
        }
    }
}
