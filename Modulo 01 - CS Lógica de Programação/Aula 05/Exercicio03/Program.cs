using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 03 *****/

            //Leia uma matriz 3 x 2 e exiba a soma dos elementos da primeira linha e a soma dos elementos da primeira coluna.

            Console.WriteLine("*** Exercício 03 - Exibir a soma dos elementos da primeira linha e coluna ***");

            int[,] mat = new int[3, 2];
            int somaLinha, somaColuna;

            for (int linha = 0; linha <= 2; linha++)
            {
                for (int coluna = 0; coluna <= 1; coluna++)
                {
                    Console.WriteLine("Digite um valor para a posição [{0},{1}] da matriz:", linha.ToString(), coluna.ToString());

                    mat[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                }
            }

            somaLinha = mat[0, 0] + mat[0, 1];
            somaColuna = mat[0, 0] + mat[1, 0];

            Console.WriteLine("Soma dos elementos da primeira linha: " + somaLinha);
            Console.WriteLine("Soma dos elementos da primeira coluna: " + somaColuna);
        }
    }
}
