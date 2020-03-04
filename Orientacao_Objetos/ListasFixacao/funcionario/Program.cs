using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionario
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Emplyoee #" + (i + 1)+":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                list.Add(new Employee (id, name, salary));

                Console.WriteLine();
                
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchID = int.Parse(Console.ReadLine());




            Console.WriteLine("Updated list of employees:");
            Console.WriteLine(list);

        }
    }
}
