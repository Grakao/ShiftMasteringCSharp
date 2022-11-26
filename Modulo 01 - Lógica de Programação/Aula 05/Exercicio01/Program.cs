using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 01 *****/

            //Faça um algoritmo que faça a união de dois vetores de mesmo tamanho e mesmo tipo em um terceiro vetor com dobro do tamanho
            
            Console.WriteLine("*** Exercício 01 - União de dois vetores de mesmo tamanho ***");

            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            int[] vetor3 = new int[10];

            //Carga do primeiro vetor
            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine("Digite o " + (i+1) + "o número do primeiro vetor:");
                vetor1[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Carga do segundo vetor
            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "o número do segundo vetor:");
                vetor2[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Junção dos vetores 1 e 2 no vetor3
            for (int i = 0, j = 0; i < vetor1.Length; i++)
            {
                vetor3[j++] = vetor1[i];
                vetor3[j++] = vetor2[i];
            }

            // Ordenação do vetor3 para facilitar a visualização no console.
            Array.Sort(vetor3);

            Console.WriteLine("Vetor 3 (Junção dos vetores 1 e 2):");
            for (int i = 0; i < vetor3.Length; i++)
            {
                Console.WriteLine(vetor3[i]);
            }
            
        }
    }
}
