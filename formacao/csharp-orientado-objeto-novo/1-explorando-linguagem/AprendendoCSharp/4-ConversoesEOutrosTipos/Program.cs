using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 - Conversões e Outros Tipos");

        int soma = 10 + 10;
        Console.WriteLine(soma);

        double salario = 3000.15;
        Console.WriteLine(salario);

        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        long x = 2000000000000000000;
        Console.WriteLine(x);

        short y = 15000;
        Console.WriteLine(y);

        float altura = 1.76f;
        Console.WriteLine(altura);

        double valor1 = 0.20;
        double valor2 = 0.10;
        double total = valor1 + valor2;
        Console.WriteLine(total);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}