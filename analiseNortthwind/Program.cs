using analiseNortthwind;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Program;
public class lerCSV
{
    static void Main()
    {
        AnaliseCsv analise = new AnaliseCsv();
        int opcao = 0;
        List<Produto> produtos = analise.LerCSV();
        while (opcao != 4)
        {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Mostrar Produtos");
        Console.WriteLine("2 - Mostrar Produtos mais vendidos");
        Console.WriteLine("3 - Mostrar Produtos menos vendidos");
        Console.WriteLine("4 - Sair");
        Console.WriteLine("--------------------------------------");

        opcao = int.Parse(Console.ReadLine());
        switch (opcao)
        {
            case 1:
                analise.MostrarProdutos(produtos);
                break;
            case 2:
                analise.ProdutosMaisVendido(produtos);
                break;
            case 3:
                analise.ProdutosMenosVendido(produtos);
                break;
            case 4:
                Console.WriteLine("Saindo do programa");
                break;
            }
        }
    }
}