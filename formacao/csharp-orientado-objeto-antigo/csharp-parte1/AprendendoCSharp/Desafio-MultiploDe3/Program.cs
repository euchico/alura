using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_MultiploDe3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                if ((i * 3) > 100)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(i * 3);
                }
            }

            Console.ReadLine();
        }
    }
}
