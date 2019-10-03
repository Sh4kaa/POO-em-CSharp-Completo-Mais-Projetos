using System;
using System.Globalization;

namespace exerccicioFix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quantQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com um peço de um produto");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura");
            string[] dados = Console.ReadLine().Split(' ');
            string lastName = dados[0];
            int idade = int.Parse(dados[1]);
            double alt = double.Parse(dados[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quantQuartos);
            Console.WriteLine(precoProduto.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(idade);
            Console.WriteLine(alt.ToString("f2", CultureInfo.InvariantCulture));


        }
    }
}
