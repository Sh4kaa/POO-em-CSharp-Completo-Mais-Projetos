using System;
using System.Globalization;

namespace produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            // entrada de dados
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // saida de dados
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            // entrada de dados
            Console.Write("Digite o numero de produtos a ser adicionado no estoque: ");
            int qte = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(qte);
            Console.WriteLine();
            
            // saidade dados
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            // entrada de dados
            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());

            p.RemoverProdutos(qte);

            Console.WriteLine();

            //saida final
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}
