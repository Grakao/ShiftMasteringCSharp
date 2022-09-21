using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 05 *****/

            //Faça um algoritmo que calcule a média de salários de uma empresa, pedindo ao usuário a quantidade de funcionários e o salário de cada funcionário.
            //Exiba a média salarial, o salário mais alto e o salário mais baixo.

            Console.WriteLine("*** Exercício 05 - Cálculo de média de salários / salários mais altos e mais baixos ***");

            int qtdeFunc;
            double soma = 0, qtd = 0;
            double salario, mediaSalarial, maisBaixo = 0, maisAlto = 0;

            Console.WriteLine("Digite a quantidade de funcionários da empresa: ");
            qtdeFunc = Convert.ToInt32(Console.ReadLine());

            int i = 1;

            while (i <= qtdeFunc)
            {
                Console.WriteLine("Digite o salário do funcionário número " + i + ":");
                salario = Convert.ToDouble(Console.ReadLine());

                if (maisBaixo == 0)
                {
                    maisBaixo = salario;
                }

                if (maisBaixo > salario)
                {
                    maisBaixo = salario;
                }

                if (salario > maisAlto)
                {
                    maisAlto = salario;
                }

                soma += salario;
                qtd = i;

                i++;
            }

            mediaSalarial = soma / qtd;

            Console.WriteLine("A média salarial é de: " + mediaSalarial + " reais.");
            Console.WriteLine("O salário mais alto é de: " + maisAlto + " reais.");
            Console.WriteLine("O salário mais baixo é de: " + maisBaixo + " reais.");
        }
    }
}
