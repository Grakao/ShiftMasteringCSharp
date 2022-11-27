using System;

namespace ProblemaTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] Conversão para Celsius;\n[2] Conversão para Fahrenheit;\n\nDigite a opção desejada:");
            var opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 0 || opcao > 2)
            {
                Console.WriteLine("Opção inválida. Selecione as opções 1 ou 2.");
                return;
            }

            Temperatura temp = new Temperatura();

            Console.WriteLine("Digite o valor da temperatura: ");
            temp.Valor = Convert.ToDouble(Console.ReadLine());

            if (opcao == 1)
            {               
                Console.WriteLine("A temperatura em Celsius é de: " + temp.Celsius().ToString());
            }
            else
            {
                Console.WriteLine("A temperatura em Fahrenheit é de: " + temp.Fahrenheit().ToString());
            }
        }
    }
}
