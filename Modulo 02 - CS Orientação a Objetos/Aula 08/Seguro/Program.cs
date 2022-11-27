using ProblemaSeguro.Entities;
using ProblemaSeguro.Enums;
using System;

namespace ProblemaSeguro
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular Valor do Seguro");

            Pessoa pes = new Pessoa();

            Console.WriteLine("Digite o nome da pessoa:");
            pes.Nome = Console.ReadLine();

            Console.WriteLine("Digite a idade da pessoa:");
            pes.Idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o sexo da pessoa:");
            pes.Sexo = ToEnum<SexoEnum>(Console.ReadLine(), true);

            Seguro seg = new Seguro();
            seg.Pessoa = pes;

            Console.WriteLine("Digite o valor do automóvel:");
            seg.ValorAutomovel = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O valor do seguro é de: R$ " + seg.CalcularSeguro().ToString() + ".");
        }

        public static T ToEnum<T>(this string value, bool ignoreCase = true)
        {
            return (T)Enum.Parse(typeof(T), value, ignoreCase);
        }
    }
}
