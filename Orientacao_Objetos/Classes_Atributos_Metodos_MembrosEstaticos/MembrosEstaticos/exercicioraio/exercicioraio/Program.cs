using System;
using System.Globalization;


namespace exercicioraio
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            Console.WriteLine("Circunferência: " + circ.ToString("f2", CultureInfo.InvariantCulture));

            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Volume: " + volume.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: "+ Calculadora.Pi.ToString("f2", CultureInfo.InvariantCulture));
            
        }

        
    }
}
