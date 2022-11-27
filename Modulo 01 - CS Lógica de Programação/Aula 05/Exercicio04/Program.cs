using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 04 *****/

            //Faça um algoritmo que some o conteúdo de dois vetores e armazene o resultado em um terceiro vetor.

            Console.WriteLine("*** Exercício 04 - Soma de dois vetores e resultado em um terceiro vetor ***");

            int somaVetor1 = 0, somaVetor2 = 0, somaVetor3 = 0;

            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            int[] vetor3 = new int[5];

            //Carga do primeiro vetor
            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "o número do primeiro vetor:");
                vetor1[i] = Convert.ToInt32(Console.ReadLine());
                somaVetor1 += vetor1[i];
            }

            //Carga do segundo vetor
            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "o número do segundo vetor:");
                vetor2[i] = Convert.ToInt32(Console.ReadLine());
                somaVetor2 += vetor2[i];
            }

            //Soma dos vetores 1 e 2
            for (int i = 0, j = 0; i < vetor1.Length; i++)
            {
                vetor3[i] = vetor1[i] + vetor2[i];
            }

            Console.WriteLine("Vetor 3 (soma dos vetores 1 e 2):");
            for (int i = 0; i < vetor3.Length; i++)
            {
                Console.WriteLine(vetor3[i]);
            }
        }
    }
}
