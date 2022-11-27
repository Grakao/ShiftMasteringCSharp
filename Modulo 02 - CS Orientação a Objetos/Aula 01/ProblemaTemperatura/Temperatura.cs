using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemaTemperatura
{
    class Temperatura
    {
        public double Valor { get; set; }

        public double Celsius()
        {
            var celsius = (5 * Valor - 160) / 9;
            return celsius;
        }

        public double Fahrenheit()
        {
            var fahrenheit = (9 * Valor + 160) / 5;
            return fahrenheit;
        }
    }
}
