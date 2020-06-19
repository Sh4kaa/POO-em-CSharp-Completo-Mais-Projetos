using CourseTaxPayer.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CourseTaxPayer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ic = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ic == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpendures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpendures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberEmployees));
                }

            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            foreach (TaxPayer contrib in list)
            {
                Console.WriteLine(contrib.Name + " $ "+ contrib.Tax().ToString("f2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES:");

            double sum = 0.0;

            foreach (TaxPayer cont in list)
            {
                
                sum += cont.Tax();                
            }

            Console.Write(sum.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine();


        }
    }
}
