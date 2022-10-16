using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                int fatorial = 1;

                for (int j = 1; j <= i; j++)
                {
                    fatorial *= j;
                }

                Console.WriteLine(i + "! = " + fatorial);
            }

            Console.ReadLine();
        }
    }
}
