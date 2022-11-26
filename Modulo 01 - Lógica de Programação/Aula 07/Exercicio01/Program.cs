using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 01 *****/

            //Escreva um programa com uma função que solicita a digitação do salário atual de um funcionário e o índice de reajuste.
            //Exiba o salário reajustado.

            Console.WriteLine("*** Exercício 01 - Exibir Salário Reajustado ***");

            double salario = 0, indice = 0, reajuste, salarioReajustado = 0;
            int opcao;

            Console.WriteLine("Selecione a opção desejada:\n\n" +
                              "1 - Input de Dados e Resultado\n" +
                              "2 - Sair\n");
            opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                EntradaDados();
                ExibirResultado();
            }
            else
            {
                return;
            }

            #region Métodos de Suporte
            void EntradaDados()
            {
                Console.WriteLine("Digite o salário atual do funcionário:");
                salario = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o índice de reajuste:");
                indice = Convert.ToDouble(Console.ReadLine());
            };

            void ExibirResultado()
            {
                reajuste = salario * indice;
                salarioReajustado = salario + reajuste;
                Console.WriteLine("O salário reajustado é de: R$ " + Math.Round(salarioReajustado, 2) + ".");
            }
            #endregion
        }
    }
}