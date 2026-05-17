using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analiseNortthwind
{
    public class AnaliseCsv
    {
        public List<Produto> LerCSV()
        {
            string caminhoArquivo = "Resultados.csv";
            string[] linhas = File.ReadAllLines(caminhoArquivo);
            List<Produto> produtos = new List<Produto>();

            foreach (string linha in linhas)
            {
                string[] colunas = linha.Split(';');
                Produto produto = new Produto();

                produto.ID = int.Parse(colunas[0]);
                produto.Nome = colunas[1];
                produto.QuantidadeVendida = int.Parse(colunas[2]);

                produtos.Add(produto);
            }
            return produtos;
        }
        public void MostrarProdutos(List<Produto> produtos)
        {
            foreach (Produto produto in produtos)
            {
                Console.WriteLine("-------------");
                Console.WriteLine($"ID: {produto.ID}");
                Console.WriteLine($"Nome: {produto.Nome}");
                Console.WriteLine($"Quantidade Vendia: {produto.QuantidadeVendida}");
            }
        }
        public void ProdutosMaisVendido(List<Produto> produtos)
        {
            Produto maisVendido = produtos[0];

            foreach (Produto produto in produtos)
            {
                if (produto.QuantidadeVendida > maisVendido.QuantidadeVendida)
                {
                    maisVendido = produto;
                }
            }
            Console.WriteLine("Produto mais vendido:");
            Console.WriteLine("ID do produto mais vendido: " + maisVendido.ID);
            Console.WriteLine("Nome do produto mais vendido: " + maisVendido.Nome);
            Console.WriteLine("Quantidade vendida do produto mais vendido: " + maisVendido.QuantidadeVendida);
        }
        public void ProdutosMenosVendido(List<Produto> produtos)
        {
            Produto menosVendido = produtos[0];
            foreach (Produto produto in produtos)
            {
                if (produto.QuantidadeVendida < menosVendido.QuantidadeVendida)
                {
                    menosVendido = produto;
                }
            }
            Console.WriteLine("Produto menos vendido:");
            Console.WriteLine("ID do produto menos vendido: " + menosVendido.ID);
            Console.WriteLine("Nome do produto menos vendido: " + menosVendido.Nome);
            Console.WriteLine("Quantidade vendida do produto menos vendido: " + menosVendido.QuantidadeVendida);
        }
    }
}
