using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNM5_Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("testando condicionais");

            int idade = 20;
            int quantidadePessoas = 3;

            if(idade >= 18)
            {
                Console.WriteLine("Você tem mais que 18 anos");
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("voce não tem 18, mas pode entrar, pois está acompanhado");
                }
                else
                {
                    Console.WriteLine("infelizmente voce não pode entrar");
                }
            }

            Console.ReadLine();
        }
    }
}
