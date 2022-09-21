using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 02 *****/

            //Uma empresa irá dar um aumento de salário aos seus funcionários de acordo com a categoria de cada empregado.
            //O aumento seguirá a seguinte regra:
            //-Funcionários das categorias A, C, F, e H ganharão 10 % de aumento sobre o salário;
            //-Funcionários das categorias B, D, e T ganharão 15 % de aumento sobre o salário;
            //-Funcionários das categorias K e R ganharão 25 % de aumento sobre o salário;

            Console.WriteLine("*** Exercício 02 - Exibir aumento de salário de acordo com a categoria ***");

            double aumento;

            Console.WriteLine("Informe o salário do funcionário:");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a categoria do funcionário:");
            string categoria = Console.ReadLine().ToUpper();

            switch (categoria)
            {
                case "A":
                case "C":
                case "F":
                case "H":
                    aumento = salario * 0.10; // aumento de 10% para as categorias A, C, F e H.
                    Console.WriteLine("Categoria " + categoria + " - " + "aumento de 10%. Aumentou em: " + aumento + " reais.");
                    break;

                case "B":
                case "D":
                case "T":
                    aumento = salario * 0.15; // aumento de 15% para as categorias B, D e T.
                    Console.WriteLine("Categoria " + categoria + " - " + " aumento de 15%. Aumentou em: " + aumento + " reais.");
                    break;

                case "K":
                case "R":
                    aumento = salario * 0.25; // aumento de 25% para as categorias K e R.
                    Console.WriteLine("Categoria " + categoria + " - " + " aumento de 25%. Aumentou em: " + aumento + " reais.");
                    break;

                default:
                    Console.WriteLine("Categoria inválida.");
                    break;
            }
        }
    }
}
