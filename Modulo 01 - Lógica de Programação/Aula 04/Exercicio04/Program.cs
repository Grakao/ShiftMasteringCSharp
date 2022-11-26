using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 04 *****/

            //Faça um algoritmo que leia um conjunto de números e imprima sua soma (Soma)e sua média(Media). Admita que o valor 9999 é utilizado como fim de leitura.
            //Ex.: 1, 2, 3, 9999 => Soma = 6 Media = 2

            Console.WriteLine("*** Exercício 04 - Ler um conjunto e imprimir a soma/média ***");

            int valor, soma = 0, media = 0, qtd = 0;

            for (int i = 1; i <= 9999; i++)
            {
                Console.WriteLine("Digite um valor: ");
                valor = Convert.ToInt32(Console.ReadLine());

                if (valor == 9999)
                {
                    i = 9999;
                }
                else
                {
                    qtd = i;
                    soma += valor;
                }
            }

            media = soma / qtd;

            Console.WriteLine("Resultado da Soma: " + soma);
            Console.WriteLine("Resultado da média: " + media);


        }
    }
}
