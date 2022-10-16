using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupaca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 11");

            double valorInvestido = 1000;

            for (int contatorMes = 1; contatorMes <= 12; contatorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + contatorMes + " você terá R$" + valorInvestido);
            }


            Console.ReadLine();
        }
    }
}
