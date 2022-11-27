using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 03 *****/

            //Faça um algoritmo que calcule a média de salários de uma empresa, pedindo ao usuário a quantidade de funcionários e o salário de cada funcionário.
            //Exiba a média salarial, o salário mais alto e o salário mais baixo.
            //O programa deve perguntar ao usuário se deseja encerrar a aplicação.
            //Números devem ser tratados.

            Console.WriteLine("*** Exercício 03 - Cálculo de média de salários / salários mais altos e mais baixos ***");

            int qtdeFunc;
            double soma = 0, qtd = 0;
            double salario, mediaSalarial, maisBaixo = 0, maisAlto = 0;
            int opcao;
            string opcaoSair;

            do
            {
                Console.WriteLine("\n[1] - Cálculo de média de salários / salários mais altos e mais baixos\n[2] - Sair\nDigite a opção desejada:");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Digite a quantidade de funcionários da empresa: ");
                    qtdeFunc = Convert.ToInt32(Console.ReadLine());

                    int i = 1;

                    while (i <= qtdeFunc)
                    {
                        Console.WriteLine("Digite o salário do funcionário número " + i + ":");
                        salario = Convert.ToDouble(Console.ReadLine());

                        if (maisBaixo == 0)
                        {
                            maisBaixo = salario;
                        }

                        if (maisBaixo > salario)
                        {
                            maisBaixo = salario;
                        }

                        if (salario > maisAlto)
                        {
                            maisAlto = salario;
                        }

                        soma += salario;
                        qtd = i;

                        i++;
                    }

                    mediaSalarial = soma / qtd;

                    Console.WriteLine("A média salarial é de: R$ " + Math.Round(mediaSalarial,2) + ".");
                    Console.WriteLine("O salário mais alto é de: R$ " + Math.Round(maisAlto,2) + ".");
                    Console.WriteLine("O salário mais baixo é de: R$ " + Math.Round(maisBaixo,2) + ".");
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
