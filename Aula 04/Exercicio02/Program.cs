using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 02 *****/

            //Crie um programa que peça 10 números inteiros e apresente: a média, o maior e o menor.

            Console.WriteLine("*** Exercício 02 - Ler 10 números e exibir média, maior e menor ***");

            int media = 0, valor, soma = 0, maior = 0, menor = 0;

            //Laço For
            Console.WriteLine("LOOP FOR");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Digite um número inteiro (iteração " + i + "):");
                valor = Convert.ToInt32(Console.ReadLine());

                soma += valor;

                if (menor == 0)
                {
                    menor = valor;
                }

                if (menor > valor)
                {
                    menor = valor;
                }
              
                if (valor > maior)
                {
                    maior = valor;
                }

                if (i == 10)
                {
                    media = soma / i;
                }
            }

            Console.WriteLine("O valor da média é: " + media);
            Console.WriteLine("O maior valor é: " + maior);
            Console.WriteLine("O menor valor é: " + menor);

            menor = 0;
            maior = 0;
            media = 0;
            soma = 0;

            //Laço While
            Console.WriteLine("LOOP WHILE");
            int j = 1;
            while (j <= 10)
            {
                Console.WriteLine("Digite um número inteiro (iteração " + j + "):");
                valor = Convert.ToInt32(Console.ReadLine());

                soma += valor;

                if (menor == 0)
                {
                    menor = valor;
                }

                if (menor > valor)
                {
                    menor = valor;
                }

                if (valor > maior)
                {
                    maior = valor;
                }

                if (j == 10)
                {
                    media = soma / j;
                }
                j++;
            }

            Console.WriteLine("O valor da média é: " + media);
            Console.WriteLine("O maior valor é: " + maior);
            Console.WriteLine("O menor valor é: " + menor);

            menor = 0;
            maior = 0;
            media = 0;
            soma = 0;

            //Laço Do While
            Console.WriteLine("LOOP DO WHILE");
            int k = 1;
            do
            {
                Console.WriteLine("Digite um número inteiro (iteração " + k + "):");
                valor = Convert.ToInt32(Console.ReadLine());

                soma += valor;

                if (menor == 0)
                {
                    menor = valor;
                }

                if (menor > valor)
                {
                    menor = valor;
                }

                if (valor > maior)
                {
                    maior = valor;
                }

                if (k == 10)
                {
                    media = soma / k;
                }
                k++;
            } while (k <= 10);

            Console.WriteLine("O valor da média é: " + media);
            Console.WriteLine("O maior valor é: " + maior);
            Console.WriteLine("O menor valor é: " + menor);
        }
    }
}
