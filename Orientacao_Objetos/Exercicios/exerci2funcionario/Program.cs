using System;
using System.Globalization;

namespace exerci2funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Funcionário: " + func);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double perc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(perc);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + func);


            
            
        }
    }
}
