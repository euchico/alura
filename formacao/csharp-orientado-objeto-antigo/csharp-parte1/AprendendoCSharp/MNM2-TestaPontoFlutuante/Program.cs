using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNM2_TestaPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 1250.70;

            Console.WriteLine("meu salario é" + salario);

            // int valor = 12.5; // Não compila
            // int valor2 = 0.0; // Não compila
            // int valor3 = teste; // Não compila

            double teste = 125.50;

            int divisao = 5 / 2;
            Console.WriteLine(divisao);

            double divisao2 = 5.0 / 2;
            Console.WriteLine(divisao2);

            Console.ReadLine();
        }
    }
}
