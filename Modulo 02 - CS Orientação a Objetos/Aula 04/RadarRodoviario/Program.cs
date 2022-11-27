using System;

namespace RadarRodoviario
{
    class Program
    {
        static void Main(string[] args)
        {
            Radar radar = new Radar();

            Console.WriteLine("Informe a frequência do carro: ");
            radar.FrequenciaCarro = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a velocidade limite da estrada: ");
            radar.VelocidadeLimite = Convert.ToInt32(Console.ReadLine());

            radar.CalcularVelocidadeCarro();
            Console.WriteLine("Velocidade do carro: " + radar.VelocidadeCarro);

            if (radar.VelocidadeCarro > radar.VelocidadeLimite)
            {
                Console.WriteLine("Infração de trânsito. Valor da multa: R$ " + radar.CalcularMulta().ToString());
            }
            else
            {
                Console.WriteLine("Velocidade do veículo dentro do limite esperado.");
            }
        }
    }
}
