using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 03 *****/

            //Crie um algoritmo que solicita ao usuário para digitar um número e mostra-lo por extenso. Este número deve variar entre 1 e 10.
            //Se o usuário introduzir um número que não está neste intervalo, mostre: "Número inválido".

            Console.WriteLine("*** Exercício 03 - Exibir número por extenso ***");

            Console.WriteLine("Digite um número de 1 a 10:");
            int numero = Convert.ToInt32(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Um");
                    break;
                case 2:
                    Console.WriteLine("Dois");
                    break;
                case 3:
                    Console.WriteLine("Três");
                    break;
                case 4:
                    Console.WriteLine("Quatro");
                    break;
                case 5:
                    Console.WriteLine("Cinco");
                    break;
                case 6:
                    Console.WriteLine("Seis");
                    break;
                case 7:
                    Console.WriteLine("Sete");
                    break;
                case 8:
                    Console.WriteLine("Oito");
                    break;
                case 9:
                    Console.WriteLine("Nove");
                    break;
                case 10:
                    Console.WriteLine("Dez");
                    break;
                default:
                    Console.WriteLine("Número inválido.");
                    break;
            }
        }
    }
}
