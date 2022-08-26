using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 02 *****/

            //Faça um programa com uma função que solicita a digitação da idade de um nadador. Classifique-o em uma das seguintes categorias:
            //-Infantil A = 5 a 7 anos
            //-Infantil B = 8 a 11 anos
            //-Juvenil A = 12 a 13 anos
            //-Juvenil B = 14 a 17 anos
            //-Adultos = Maiores de 18 anos
            //Faça o retorno do resultado

            Console.WriteLine("*** Exercício 02 - Solicitar e exibir a idade de um nadador de acordo com a categoria (retorno) ***");

            int input;

            Console.WriteLine("Digite a idade do(a) nadador(a):");
            input = Convert.ToInt32(Console.ReadLine());
            
            ClassificarIdade(input);

            Console.WriteLine("A categoria do(a) nadador(a) é: " + ClassificarIdade(input));

            string ClassificarIdade(int idade)
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

                return categoria;
            }
        }
    }
}
