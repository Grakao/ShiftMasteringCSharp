using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** Exercicio 03 *****/

            //Faça um algoritmo que:
            //a) Obtenha o valor para a variável HT(horas trabalhadas no mês);
            //b) Obtenha o valor para a variável VH(valor hora trabalhada):
            //c) Obtenha o valor para a variável PD(percentual de desconto);
            //d) Calcule o salário bruto => SB = HT * VH;
            //e) Calcule o total de desconto => TD = (PD / 100) * SB;
            //f) Calcule o salário líquido => SL = SB – TD;
            //g) Apresente os valores de: Horas trabalhadas, Salário Bruto, Desconto, Salário Liquido

            Console.WriteLine("*** Exercício 03 - Cálculo de horas trabalhadas, salários e descontos ***");

            Console.WriteLine("Digite o total de horas trabalhadas no mês: ");
            var ht = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor por hora trabalhada: ");
            var vh = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o percentual de desconto: ");
            var pd = Convert.ToDouble(Console.ReadLine());

            var salarioBruto = ht * vh;
            var valorDesconto = (pd / 100) * salarioBruto;

            var salarioLiquido = salarioBruto - valorDesconto;

            Console.WriteLine("Horas trabalhadas: " + ht);
            Console.WriteLine("Salário Bruto: " + salarioBruto);
            Console.WriteLine("Desconto: " + valorDesconto);
            Console.WriteLine("Salário Líquido: " + salarioLiquido);
        }
    }
}
