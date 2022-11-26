using System;

namespace AutonomiaVeiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();

            Console.WriteLine("Digite a quantidade de combustível total:");
            carro.QtdCombustivel = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de Km por litro do carro (rendimento):");
            carro.Rendimento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A autonomia do carro é de: " + carro.Autonomia(carro.QtdCombustivel, carro.Rendimento).ToString() + " Km.");
        }
    }
}