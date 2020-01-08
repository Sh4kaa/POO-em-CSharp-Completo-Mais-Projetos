using System;
using System.Globalization;

namespace Exercicioretangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
            

            Console.WriteLine("Entre a largura e altura do retângulo:");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = "+ ret.Area().ToString("f2", CultureInfo.InvariantCulture));

            Console.WriteLine("PERÍMETRO = " + ret.Perimetro().ToString("f2", CultureInfo.InvariantCulture));

            Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("f2", CultureInfo.InvariantCulture));


        }
    }
}
