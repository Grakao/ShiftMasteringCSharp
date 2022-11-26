using System;
using System.Collections.Generic;
using System.Text;

namespace AutonomiaVeiculo
{
    public class Veiculo
    {
        #region Construtores
        public Veiculo()
        {

        }
        #endregion

        #region Propriedades
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public double ValorVenda { get; set; }
        #endregion
    }
}