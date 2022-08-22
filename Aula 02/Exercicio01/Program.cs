using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 01 *****/

            //O sistema de avaliação de determinada disciplina, é composto por três provas.A primeira prova tem peso 2, a segunda tem peso 3 e a terceira tem peso 5.
            //Faça um algoritmo para calcular a média final de um aluno desta disciplina.

            Console.WriteLine("*** Exercício 01 - Calcular a média final de um aluno ***");

            double resultado1, resultado2, resultado3, mediaFinal;
            int peso1 = 2, peso2 = 3, peso3 = 5;

            Console.WriteLine("Digite a NOTA da primeira prova: ");
            var nota1 = Convert.ToDouble(Console.ReadLine());
            resultado1 = nota1 * peso1;

            Console.WriteLine("Digite a NOTA da segunda prova: ");
            var nota2 = Convert.ToDouble(Console.ReadLine());
            resultado2 = nota2 * peso2;

            Console.WriteLine("Digite a NOTA da terceira prova: ");
            var nota3 = Convert.ToDouble(Console.ReadLine());
            resultado3 = nota3 * peso3;

            //Média ponderada das notas
            mediaFinal = (resultado1 + resultado2 + resultado3) / (peso1 + peso2 + peso3);

            Console.WriteLine("A média final do aluno é: " + mediaFinal);
        }
    }
}
