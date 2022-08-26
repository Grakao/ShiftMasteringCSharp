using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 05 *****/

            // Faça um programa que contenha uma função que leia o índice de poluição e emita a notificação adequada aos diferentes grupos de empresas.
            // O algoritmo só deve parar de rodar quando o usuário responder "S" na seguinte pergunta:  "Deseja encerrar o programa?"
            // Repetir o exercicio 05 só que com parâmetro de entrada.

            Console.WriteLine("*** Exercício 06 - Emitir notificação de poluição (Parâmetro de Entrada)");

            int opcao;
            string opcaoSair;
            double indice;

            Console.WriteLine("Digite a opção Adequada:\n1 - Efetuar Calculo\n2 - Sair do Programa");
            opcao = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (opcao == 1)
                {
                    Console.WriteLine("Informe o índice de poluição:");
                    indice = Convert.ToDouble(Console.ReadLine());

                    CalcularIndice(indice);
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

            void CalcularIndice(double indice)
            {
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
