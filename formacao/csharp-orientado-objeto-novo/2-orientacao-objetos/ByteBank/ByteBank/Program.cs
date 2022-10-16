using ByteBank;
using ByteBank.Titular;


Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

ContaCorrente conta1 = new ContaCorrente(68, "123456-X");
ContaCorrente conta2 = new ContaCorrente(97, "654321-X");

Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Console.ReadKey();