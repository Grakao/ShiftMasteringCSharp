using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 02 *****/

            //Crie um algoritmo que calcula o desconto previdenciário de um funcionário.
            //Dado um salário, o programa deve retornar o valor do desconto proporcional ao mesmo.
            //O cálculo segue a regra: o desconto é de 11 % do valor do salário, entretanto, o valor máximo de desconto é 720,00.
            //Sendo assim, ou o algoritmo retorna o valor equivalente a 11 % sobre o salário ou 720,00.
            //O programa deve perguntar se o usuário deseja encerrar a aplicação. Números devem ser tratados.

            Console.WriteLine("*** Exercício 02 - Cálculo do desconto previdenciário de um funcionário ***");

            int opcao;
            string opcaoSair;
            double salario, desconto, salarioDescontado;

            do
            {
                Console.WriteLine("\n[1] - Cálculo do desconto previdenciário\n[2] - Sair\nDigite a opção desejada:");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Digite o valor do salário: ");
                    salario = Convert.ToDouble(Console.ReadLine());
                    desconto = ((double)11 / 100);
                    salarioDescontado = Math.Round(salario,2) * Math.Round(desconto,2);

                    if (salarioDescontado > 720)
                    {
                        Console.WriteLine("O valor do desconto é de 720 reais.");
                    }
                    else
                    {
                        Console.WriteLine("O valor do desconto é de R$" + Math.Round(salarioDescontado,2) + ".");
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
