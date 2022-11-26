using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemaConta
{
    public class Conta
    {
        public Conta()
        {
            TipoConta = Convert.ToInt32(TipoContaEnum.CORRENTE); // Conta Padrão
        }

        public Conta(int tipo)
        {
            TipoConta = tipo;
        }

        #region Propriedades
        public string Titular { get; set; }

        public double Saldo { get; set; }

        public int TipoConta { get; set; }
        #endregion

        #region Métodos
        public bool Depositar(double valor, int conta)
        {
            if (valor > 1000 && conta == 0)
            {
                return false;
            }
            else
            {
                Saldo += valor;
                return true;
            }
        }

        public bool Sacar(double valor)
        {
            if (valor > Saldo)
            {
                return false;
            }
            else
            {
                Saldo -= valor;
                return true;
            }           
        }

        public bool Transferir(double valor, Conta origem, Conta destino)
        {
            if (origem.TipoConta == 1)
            {
                return false;
            }
            else
            {
                origem.Saldo -= valor;
                destino.Saldo += valor;
                return true;
            }            
        }
        #endregion




    }
}
