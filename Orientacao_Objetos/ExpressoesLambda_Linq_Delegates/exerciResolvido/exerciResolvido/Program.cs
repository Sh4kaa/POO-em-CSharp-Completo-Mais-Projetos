using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.IO;
using exerciResolvido.Entities;

namespace exerciResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> list = new List<Employee>(); // lista de funcionarios
            // bloco try
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    // lendo o arquivo de dados
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee(name, email, salary));
                    }
                }
                
                Console.Write("Enter salary: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Email of people whose salary is more than: " + amount.ToString("f2", CultureInfo.InvariantCulture));

                // filtrando a lista de funcionarios por e-mail, que tenham salario maior que a quantia definida, selecionando apenas o e-mail(sem ser objeto inteiro) 
                var funcEmail = list.Where(f => f.Salary > amount).OrderBy(f => f.Email).Select(f => f.Email); 

                foreach (string email in funcEmail)
                {
                    Console.WriteLine(email);
                }

                double sum = list.Where(f => f.Name[0] == 'M').Sum(f => f.Salary);
                Console.Write("Sum of salary of people whose name starts with 'M': " + sum.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine();
            }

            // bloco catch
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }




        }
    }
}
