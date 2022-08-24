using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 02 *****/

            //Escreva um programa com uma função que solicita a digitação do salário atual de um funcionário e o índice de reajuste.
            //Exiba o salário reajustado.
            //OBS.: Igual ao exercício 01, só que utilizando parâmetros de entrada nos métodos.

            Console.WriteLine("*** Exercício 02 - Exibir Salário Reajustado (Parâmetros de Entrada) ***");

            double input1, input2;
            int opcao;

            Console.WriteLine("Selecione a opção desejada:\n\n" +
                              "1 - Input de Dados e Resultado\n" +
                              "2 - Sair\n");
            opcao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o salário atual do funcionário:");
            input1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o índice de reajuste:");
            input2 = Convert.ToDouble(Console.ReadLine());

            if (opcao == 1)
            {
                ExibirResultado(input1, input2);
            }
            else
            {
                return;
            }

            #region Métodos de Suporte
            void ExibirResultado(double salario, double indice)
            {
                double reajuste, salarioReajustado;

                reajuste = salario * indice;
                salarioReajustado = salario + reajuste;
                Console.WriteLine("O salário reajustado é de: R$ " + Math.Round(salarioReajustado, 2) + ".");
            }
            #endregion
        }
    }
}
