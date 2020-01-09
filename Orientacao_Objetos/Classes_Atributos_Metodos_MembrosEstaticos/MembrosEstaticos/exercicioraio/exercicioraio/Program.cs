using System;
using System.Globalization;


namespace exercicioraio
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            Console.WriteLine("Circunferência: " + circ.ToString("f2", CultureInfo.InvariantCulture));

            double volume = Volume(raio);
            Console.WriteLine("Volume: " + volume.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: "+ Pi.ToString("f2", CultureInfo.InvariantCulture));
            
        }

        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r; // formula do raio
        }

        static double Volume(double r)
        {
             return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0); // 4 terços de * Pi * raio elevado ao cubo. formula do volume
        }
    }
}
