using System;
using System.Globalization;

namespace conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é  a cotação do dolar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar: ");
            double quantDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.CotacaoDolar(cotacao, quantDolar);


            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
