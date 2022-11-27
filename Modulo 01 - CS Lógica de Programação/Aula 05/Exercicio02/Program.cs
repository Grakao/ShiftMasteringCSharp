using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 02 *****/

            //Faça um algoritmo que leia uma matriz mat 2 x 3 e imprima na tela a SOMA de todos os elementos pares da matriz mat

            Console.WriteLine("*** Exercício 02 - Imprimir elementos pares da matriz ***");

            int[,] mat = new int[2, 3];
            int somaPares = 0;

            for (int linha = 0; linha <= 1; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.WriteLine("Digite um valor para a posição [{0},{1}] da matriz:", linha.ToString(), coluna.ToString());

                    mat[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int linha = 0; linha <= 1; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    if (mat[linha,coluna] % 2 == 0)
                    {
                        somaPares += mat[linha,coluna];
                    }
                }
            }

            Console.WriteLine("A soma de números pares é de: " + somaPares);
        }
    }
}
