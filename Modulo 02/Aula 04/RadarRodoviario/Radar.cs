using System;
using System.Collections.Generic;
using System.Text;

namespace RadarRodoviario
{
    public class Radar
    {
        #region Propriedades
        public double FrequenciaCarro { get; set; }

        public int VelocidadeLimite { get; set; }

        public double VelocidadeCarro { get; set; }
        #endregion

        #region Métodos
        public void CalcularVelocidadeCarro()
        {
            VelocidadeCarro = 300 * (1 / FrequenciaCarro) - 1;
        }

        public double CalcularMulta()
        {
            double multa;
            double vintePerc = VelocidadeLimite * 0.2;
            double limite20perc = VelocidadeLimite + vintePerc;           

            if (VelocidadeCarro > VelocidadeLimite && VelocidadeCarro <= limite20perc)
            {                
                multa = 127.69;
                return multa;
            }

            if (VelocidadeCarro > limite20perc)
            {               
                multa = 574.62;
                return multa;
            }

            return 0;
        }
        #endregion
    }
}
