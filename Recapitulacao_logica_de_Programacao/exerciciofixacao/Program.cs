using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciofixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é $ {1:f2}", produto1, preco1);
            Console.WriteLine("{0} cujo preço é {1:f2}", produto2, preco2);

            Console.WriteLine();

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");

            Console.WriteLine();

            Console.WriteLine("Medida com oitro casas decimais: {0:f8}", medida);
            Console.WriteLine("Arredondamento (três casas decimais): {0:f3}", medida);
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }
    }
}
