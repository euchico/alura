using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 10 -  Calcula Poupança");

            double valorInvestido = 1000;
            int contatorMes = 1;

            while (contatorMes <= 12)
            {
                // 0.36% = 0.0036
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contatorMes + " você terá R$" + valorInvestido);

                // contadorMes = contatorMes + 1
                // contadorMes += 1;
                contatorMes++;
            }

            Console.ReadLine();
        }
    }
}
