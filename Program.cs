﻿using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Informe qual operação deseja executar:");
        Console.WriteLine("1 - Calcular custo");
        Console.WriteLine("2 - Calcular Raio");
        Console.WriteLine("3 - Calcular preco");
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                CalculaCusto();
                break;

            case "2":
                CalculaRaio();
                break;

            case "3":
                CalculaPreco();
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }

    static void CalculaCusto()
    {
        int cod1, cod2, quant1, quant2;
        float prec1, prec2;

        Console.WriteLine("Informe o Código do 1° produto, a quantidade e o preço (Separados por espaço):");
        string[] entrada1 = Console.ReadLine().Split(' ');

        if (entrada1.Length < 3)
        {
            Console.WriteLine("Entrada inválida! Certifique-se de inserir os valores separados por espaço.");
            return;
        }

        cod1 = int.Parse(entrada1[0]);
        quant1 = int.Parse(entrada1[1]);
        prec1 = float.Parse(entrada1[2]);

        Console.WriteLine("Informe o Código do 2° produto, a quantidade e o preço (Separados por espaço):");
        string[] entrada2 = Console.ReadLine().Split(' ');

        if (entrada2.Length < 3)
        {
            Console.WriteLine("Entrada inválida! Certifique-se de inserir os valores separados por espaço.");
            return;
        }

        cod2 = int.Parse(entrada2[0]);
        quant2 = int.Parse(entrada2[1]);
        prec2 = float.Parse(entrada2[2]);

        float custoTotal1 = quant1 * prec1;
        float custoTotal2 = quant2 * prec2;
        float custoFinal = custoTotal1 + custoTotal2;

        Console.WriteLine($"Produto 1: Código {cod1}, Quantidade {quant1}, Preço {prec1}, Custo Total: {custoTotal1}");
        Console.WriteLine($"Produto 2: Código {cod2}, Quantidade {quant2}, Preço {prec2}, Custo Total: {custoTotal2}");
        Console.WriteLine($"Custo Final dos Produtos: {custoFinal}");
    }

    static void CalculaRaio()
    {
        const double pi = 3.14159;
        double resultado;

        Console.WriteLine("Informe o raio:");
        double raio = double.Parse(Console.ReadLine());
        resultado = pi*Math.Pow(raio, 2);
        Console.WriteLine($"A área do circulo é:{resultado:F2}");
    }

    static void CalculaPreco()
    {
        Console.WriteLine("Cardapio");
        Console.WriteLine("");
        Console.WriteLine("1 - Cachorro Quente - R$ 4.00");
        Console.WriteLine("2 - X-Salada - R$ 4.50");
        Console.WriteLine("3 - X-Bacon - R$ 5.00");
        Console.WriteLine("4 - Torrada Simples - R$ 2.00");
        Console.WriteLine("5 - Refrigerante - R$ 1.50");
        Console.WriteLine("");

        Console.WriteLine("Informe o codigo do produto:");
        int codigo = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe a Quantidade:");
        int quantidade = int.Parse(Console.ReadLine());

        double preco = 0;

        switch (codigo)
        {
            case 1:
                preco = 4.00;
                break;

            case 2:
                preco = 4.50;
                break;

            case 3:
                preco = 5.00;
                break;
            
            case 4:
                preco = 2.00;
                break;
            
            case 5:
                preco = 1.50;
                break;
            
            default:
                Console.WriteLine("Codigo não encontrado");
                break;
        }
        
        double total = preco * quantidade;

        Console.WriteLine($"O valor total a pagar: {total:F2}");
    }

}
