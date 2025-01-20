using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe qual operação deseja executar: 1 - Estrutura Sequencial");
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                EstruturaSequencial();
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }

    static void EstruturaSequencial()
    {
        int cod1, cod2, quant1, quant2;
        float prec1, prec2;

        // Entrada do primeiro produto
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

        // Entrada do segundo produto
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

        // Cálculo dos custos
        float custoTotal1 = quant1 * prec1;
        float custoTotal2 = quant2 * prec2;
        float custoFinal = custoTotal1 + custoTotal2;

        // Exibição dos resultados
        Console.WriteLine($"Produto 1: Código {cod1}, Quantidade {quant1}, Preço {prec1}, Custo Total: {custoTotal1}");
        Console.WriteLine($"Produto 2: Código {cod2}, Quantidade {quant2}, Preço {prec2}, Custo Total: {custoTotal2}");
        Console.WriteLine($"Custo Final dos Produtos: {custoFinal}");
    }
}
