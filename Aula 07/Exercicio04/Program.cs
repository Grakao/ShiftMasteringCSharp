using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                /***** Exercicio 04 *****/

                //Faça um programa com uma função que solicita a digitação da idade de um nadador. Classifique-o em uma das seguintes categorias:
                //-Infantil A = 5 a 7 anos
                //-Infantil B = 8 a 11 anos
                //-Juvenil A = 12 a 13 anos
                //-Juvenil B = 14 a 17 anos
                //-Adultos = Maiores de 18 anos
                //Remake do exercicio 3, só que com parâmetro de entrada no método

                Console.WriteLine("*** Exercício 04 - Solicitar e exibir a idade de um nadador de acordo com a categoria (Parametro) ***");

                int idade;
                Console.WriteLine("Digite a idade do(a) nadador(a):");
                idade = Convert.ToInt32(Console.ReadLine());
                ClassificarIdade(idade);

                void ClassificarIdade(int idade)
                {
                    string categoria = string.Empty;

                    if (idade >= 5 && idade <= 7)
                    {
                        categoria = "Infantil A";
                    }
                    else if (idade >= 8 && idade <= 11)
                    {
                        categoria = "Infantil B";
                    }
                    else if (idade >= 12 && idade <= 13)
                    {
                        categoria = "Juvenil A";
                    }
                    else if (idade >= 14 && idade <= 17)
                    {
                        categoria = "Juvenil B";
                    }
                    else if (idade >= 18)
                    {
                        categoria = "Adultos";
                    }
                    else
                    {
                        Console.WriteLine("Idade inapropriada.");
                        return;
                    }

                    Console.WriteLine("A categoria do(a) nadador(a) é: " + categoria.ToString());
                }
            }
        }
    }
}
