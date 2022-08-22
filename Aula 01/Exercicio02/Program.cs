using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 02 *****/

            //Faça um algoritmo que:
            //a) Leia o nome;
            //b) Leia o sobrenome;
            //c) Concatene o nome com o sobrenome;
            //d) Apresente o nome completo.

            Console.WriteLine("*** Exercício 02 - Exibição do nome completo ***");

            Console.WriteLine("Digite o seu primeiro nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite o seu sobrenome: ");
            var sobrenome = Console.ReadLine();

            Console.WriteLine("Nome completo: " + nome + " " + sobrenome);
        }
    }
}
