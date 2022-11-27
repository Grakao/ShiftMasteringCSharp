using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 01 *****/

            //Construa um Algoritmo que, para um grupo de 10 valores inteiros, determine:
            //a) A soma dos números positivos;
            //b) A quantidade de valores negativos;

            Console.WriteLine("*** Exercício 01 - Determinar soma positiva e quantidade negativa ***");

            int valor = 0, soma = 0, qtdNegativa = 0;

            // Loop For
            Console.WriteLine("Laço: FOR");
            for (int i = 1; i <= 10; i++)
            {               
                Console.WriteLine("Digite um valor inteiro (iteração " + i + "):");
                valor = Convert.ToInt32(Console.ReadLine());

                if (valor >= 0)
                {
                    soma += valor;
                }
                else
                {
                    qtdNegativa += 1;
                }
            }

            Console.WriteLine("Soma dos valores positivos: " + soma);
            Console.WriteLine("Quantidade de valores negativos: " + qtdNegativa);

            soma = 0; // reset da variável soma para não afetar os outros laços
            qtdNegativa = 0; // reset da variável qtdNegativa para não afetar os outros laços

            // Loop While
            int j = 1;
            Console.WriteLine("Laço: WHILE");
            while (j <= 10)
            {
                Console.WriteLine("Digite um valor inteiro (iteração " + j + "):");
                valor = Convert.ToInt32(Console.ReadLine());

                if (valor >= 0)
                {
                    soma += valor;
                }
                else
                {
                    qtdNegativa += 1;
                }
                j++;
            }

            Console.WriteLine("Soma dos valores positivos: " + soma);
            Console.WriteLine("Quantidade de valores negativos: " + qtdNegativa);

            soma = 0; // reset da variável soma para não afetar os outros laços
            qtdNegativa = 0; // reset da variável qtdNegativa para não afetar os outros laços

            // Loop Do While
            int k = 1;
            Console.WriteLine("Laço: DO WHILE");
            do
            {
                Console.WriteLine("Digite um valor inteiro (iteração " + k + "):");
                valor = Convert.ToInt32(Console.ReadLine());

                if (valor >= 0)
                {
                    soma += valor;
                }
                else
                {
                    qtdNegativa += 1;
                }
                k++;
            } while (k <= 10);

            Console.WriteLine("Soma dos valores positivos: " + soma);
            Console.WriteLine("Quantidade de valores negativos: " + qtdNegativa);
        }
    }
}
