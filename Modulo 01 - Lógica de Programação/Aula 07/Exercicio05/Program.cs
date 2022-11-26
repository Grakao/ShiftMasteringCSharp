using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 05 *****/

            // Faça um programa que contenha uma função que leia o índice de poluição e emita a notificação adequada aos diferentes grupos de empresas.
            // O algoritmo só deve parar de rodar quando o usuário responder "S" na seguinte pergunta:  "Deseja encerrar o programa?"

            Console.WriteLine("*** Exercício 05 - Emitir notificação de poluição");

            int opcao;
            string opcaoSair;
            double indice;

            Console.WriteLine("Digite a opção Adequada:\n1 - Efetuar Calculo\n2 - Sair do Programa");
            opcao = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (opcao == 1)
                {
                    CalcularIndice();
                    opcao = 0;
                }
                else
                {
                    Console.WriteLine("Deseja encerrar o programa? [S] / [N]");
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

            void CalcularIndice()
            {
                Console.WriteLine("Informe o índice de poluição:");
                indice = Convert.ToDouble(Console.ReadLine());

                if (indice >= 0.3 && indice < 0.4)
                {
                    Console.WriteLine("Indústrias do 1o Grupo devem suspender as atividades.");
                }
                else if (indice >= 0.4 && indice < 0.5)
                {
                    Console.WriteLine("Indústrias do 1o e 2o Grupos devem suspender as atividades.");
                }
                else if (indice >= 0.5)
                {
                    Console.WriteLine("Todos os grupos devem suspender as atividades.");
                }
                else
                {
                    Console.WriteLine("Niveis de poluição na normalidade. Nenhuma ação é necessária.");
                }
            }
        }
    }
}
