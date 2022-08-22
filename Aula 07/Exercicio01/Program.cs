using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, res;
            int opcao;

            Console.WriteLine("Minha Super Calculadora\n\n");
            Console.WriteLine("Digite o primeiro número: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Agora, selecione a operação:\n\n" +
                "1 - Adição\n" +
                "2 - Subtração\n" +
                "3 - Multiplicação\n" +
                "4 - Divisão\n");
            opcao = Convert.ToInt32(Console.ReadLine());
            
            switch (opcao)
            {
                case 1:
                    res = n1 + n2;
                    Console.WriteLine("Soma {0}", res.ToString());
                    break;

                case 2:
                    res = n1 - n2;
                    Console.WriteLine("Soma {0}", res.ToString());
                    break;

                case 3:
                    res = n1 * n2;
                    Console.WriteLine("Soma {0}", res.ToString());
                    break;

                case 4:
                    if (n2 != 0)
                    {
                        res = n1 / n2;
                        Console.WriteLine("Soma {0}", res.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Impossível dividir por zero!");
                    }
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}