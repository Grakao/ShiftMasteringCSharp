using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 01 *****/

            //Uma empresa irá dar um aumento de salário aos seus funcionários de acordo com a categoria de cada empregado. O aumento seguirá a seguinte regra:
            //-Funcionários das categorias A, C, F, e H ganharão 10 % de aumento sobre o salário;
            //-Funcionários das categorias B, D, e T ganharão 15 % de aumento sobre o salário;
            //-Funcionários das categorias K e R ganharão 25 % de aumento sobre o salário;
            //O programa deve perguntar se o usuário deseja encerrar a aplicação. Números devem ser tratados

            Console.WriteLine("*** Exercício 01 - Exibir aumento de salário de acordo com a categoria ***");

            double aumento;
            int opcao;
            string opcaoSair;

            do
            {
                Console.WriteLine("\n[1] - Exibição do Aumento de Salário de Acordo com a Categoria\n[2] - Sair\nDigite a opção desejada:");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
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
                            Console.WriteLine("Categoria " + categoria + " - " + "aumento de 10%. Aumentou em: R$ " + Math.Round(aumento,2) + ".");
                            break;

                        case "B":
                        case "D":
                        case "T":
                            aumento = salario * 0.15; // aumento de 15% para as categorias B, D e T.
                            Console.WriteLine("Categoria " + categoria + " - " + " aumento de 15%. Aumentou em: R$ " + Math.Round(aumento, 2) + ".");
                            break;

                        case "K":
                        case "R":
                            aumento = salario * 0.25; // aumento de 25% para as categorias K e R.
                            Console.WriteLine("Categoria " + categoria + " - " + " aumento de 25%. Aumentou em: R$ " + Math.Round(aumento, 2) + ".");
                            break;

                        default:
                            Console.WriteLine("Categoria inválida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Tem certeza que deseja sair? [S] / [N]:");
                    opcaoSair = Console.ReadLine().ToUpper();
                    if (opcaoSair.Equals("S"))
                    {
                        opcao = 2;
                    }
                    else
                    {
                        opcao = 1;
                    }
                }

            } while (opcao != 2);        
        }
    }
}
