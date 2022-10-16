using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Guilherme";
            cliente.CPF = "435.654.987-20";
            cliente.Profissao = "Médico";

            conta.Saldo = -10;

            Console.WriteLine(conta.Titular);
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}
