using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo x, y; // variaveis do tipo triangulo

            x = new Triangulo(); // estanciação do atributo do x
            y = new Triangulo(); // estanciação do atributo do x


            // entrada triangulo X
            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // entrada tringulo Y
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área de X = " + areaX.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("f4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("A maior área é a área X");
            } else
            {
                Console.WriteLine("A maior área é a área y");
            }


        }
    }
}
