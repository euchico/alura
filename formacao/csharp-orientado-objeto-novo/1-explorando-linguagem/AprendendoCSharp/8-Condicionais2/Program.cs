﻿using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 8 - Condicionais 2");

        int idadeJoao = 15;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}