using System;

namespace RadarRodoviario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Radar radar = new Radar();

            Console.WriteLine("Informe a frequência do carro: ");
            radar.FrequenciaCarro = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a velocidade limite da estrada: ");
            radar.VelocidadeLimite = Convert.ToInt32(Console.ReadLine());

            radar.CalcularVelocidadeCarro();
            Console.WriteLine("Velocidade do carro: " + radar.VelocidadeCarro);

            if (radar.VelocidadeCarro > radar.VelocidadeLimite)
            {
                Console.WriteLine("Valor da Multa: " + radar.CalcularMulta().ToString());
            }
            Console.WriteLine();
        }
    }
}
