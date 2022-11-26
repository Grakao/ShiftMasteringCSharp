using System;

namespace ProblemaConta
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Conta cc = new Conta();
            cc.Titular = "Gastaldo Correia";
            cc.Saldo = 5000.00;

            Conta cp = new Conta(1);
            cp.Titular = "Severino Meriades";
            cp.Saldo = 2200.00;

            int opcao;
            int conta;
            double valor;           

            do
            {
                Console.WriteLine("\nDigite a opção desejada: \n\n[1] Saque;\n[2] Depósito;\n[3] Transferência;\n[4] Sair. ");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Informe a conta: ");
                    conta = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o valor do saque: ");
                    valor = Convert.ToDouble(Console.ReadLine());

                    if (conta == 0)
                    {
                        if (cc.Sacar(valor))
                        {
                            Console.WriteLine("Saque da conta corrente efetuado com sucesso. Saldo atual: " + cc.Saldo.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Valor de saque supera o saldo da conta! Repita a operação.");
                        }
                    }
                    else
                    {
                        if (cp.Sacar(valor))
                        {
                            Console.WriteLine("Saque da conta poupança efetuado com sucesso. Saldo atual: " + cp.Saldo.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Valor de saque supera o saldo da conta! Repita a operação.");
                        }
                    }
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Informe a conta: ");
                    conta = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o valor do depósito: ");
                    valor = Convert.ToDouble(Console.ReadLine());

                    if (conta == 0)
                    {
                        if (cc.Depositar(valor, conta))
                        {
                            Console.WriteLine("Depósito em conta corrente efetuado com sucesso! Saldo atual: " + cc.Saldo.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Valor do depósito supera o valor permitido. Tente novamente.");
                        }
                    }
                    else
                    {
                        if (cp.Depositar(valor, conta))
                        {
                            Console.WriteLine("Depósito em conta poupança efetuado com sucesso! Saldo atual: " + cp.Saldo.ToString());
                        }
                    }                  
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Informe a conta origem: ");
                    conta = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o valor da transferência: ");
                    valor = Convert.ToDouble(Console.ReadLine());

                    if (conta == 0)
                    {
                        if (cc.Transferir(valor, cc, cp))
                        {
                            Console.WriteLine("Transferência da conta corrente para a conta poupança realizada!\nSaldo CC: " + cc.Saldo.ToString() + "\nSaldo CP: " + cp.Saldo.ToString());
                        }                       
                    }
                    else
                    {
                        Console.WriteLine("Não é permitido realizar transferências da conta poupança.");
                    }
                }

            } while (opcao != 4);
            
        }
    }
}
