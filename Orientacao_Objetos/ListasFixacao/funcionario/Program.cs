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

            List<Employee> list = new List<Employee>(); // estanciando lista do tipo Employee(tipo classe)

            Console.WriteLine(); // pula linha

            // varrendo a lista estanciada
            for (int i = 1; i <= n; i++)  
            {
                Console.WriteLine("Emplyoee #" + i +":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                list.Add(new Employee (id, name, salary)); //passando os parametros e adicionando na lista

                Console.WriteLine();
                
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchID = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchID); /* fazendo a comparação se o Id(objeto) é igual ao id
            da variavel searchID ("emp" recebe o resultado da comparacao ) */

            if(emp != null) // se oq estiver na lista for diferente de nulo execute abaixo
            {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percent);
                
            } else
            {
                Console.WriteLine("This id does not exist!");
                
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            
            // varrendo a lista e mostrando os valores
            foreach(Employee obj in list)
            {
                Console.WriteLine(obj);
            }







        }
    }
}
