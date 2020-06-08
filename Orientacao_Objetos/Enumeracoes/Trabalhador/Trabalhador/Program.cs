using System;
using Trabalhador.Entities.Enums;
using System.Globalization;
using Trabalhador.Entities;

namespace Trabalhador
{
    class Program
    {
        static void Main(string[] args)
        {
            // entrando com o nome do departmento
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();

            // entrando com os dados do trabalhador
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            // definindo o nivel do trabalhador
            Console.Write("Level(Junior / MidLevel / Senior): ");
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof (WorkerLevel),Console.ReadLine());

            // definindo salario base
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            //varrendo os contratos
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);

                worker.AddContract(contract);
            }

            Console.WriteLine();

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYeart = Console.ReadLine();
            int month = int.Parse(monthAndYeart.Substring(0, 2)); // recortando a string a partir da posição 0 e anda 2 casas
            int year = int.Parse(monthAndYeart.Substring(3)); // recortando a string a partir da posição 3 em diante(até o final)


            Console.WriteLine("Name " + worker.Name);
            Console.WriteLine("Department "+ worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYeart + ": " + worker.Income(year, month).ToString("F2",CultureInfo.InvariantCulture));



        }
    }
}
