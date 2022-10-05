using System;
using System.Collections.Generic;
using System.Text;

namespace AutonomiaVeiculo
{
    public class Carro : Veiculo
    {
        #region Construtores
        public Carro() : base() // Exemplo de construtor da subclasse chamando o construtor da superclasse.
        {

        }
        #endregion

        #region Propriedades
        public double QtdCombustivel { get; set; }

        public int Rendimento { get; set; }
        #endregion

        #region Métodos
        public double Autonomia(double qtdComb, int rend)
        {
            return qtdComb * rend;
        }
        #endregion

    }
}