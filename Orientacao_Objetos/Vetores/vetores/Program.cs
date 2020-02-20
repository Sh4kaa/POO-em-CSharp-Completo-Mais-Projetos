using System;
using System.Globalization;

namespace vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;            
            for (int i = 0; i < n; i++)
            {
                soma = soma + vet[i];                
            }

            double media = soma / n;
            Console.WriteLine("AVERAGE HEIGHT = "+ media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
