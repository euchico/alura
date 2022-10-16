using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correcao_WhileEmFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            Console.WriteLine();

            for (int contadorFor = 1; contadorFor <= 10; contadorFor++)
            {
                Console.WriteLine(contadorFor);
            }

            Console.ReadLine();
        }
    }
}
