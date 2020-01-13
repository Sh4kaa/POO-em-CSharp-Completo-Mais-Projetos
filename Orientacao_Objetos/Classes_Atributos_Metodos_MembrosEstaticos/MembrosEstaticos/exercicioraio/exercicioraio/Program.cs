using System;
using System.Globalization;


namespace exercicioraio
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circunferencia(raio);
            Console.WriteLine("Circunferência: " + circ.ToString("f2", CultureInfo.InvariantCulture));

            double volume = calc.Volume(raio);
            Console.WriteLine("Volume: " + volume.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: "+ calc.Pi.ToString("f2", CultureInfo.InvariantCulture));
            
        }

        
    }
}
