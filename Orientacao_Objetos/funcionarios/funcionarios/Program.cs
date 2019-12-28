using System;
using System.Globalization;
namespace funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario(); // chamei classe, criei uma variavel e instanciei a classe;
            Funcionario f2 = new Funcionario();

            //dados primeiro funcionário
            Console.WriteLine("Dados do primeiro funcionário");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //dados segundo funcionario

            Console.WriteLine("Dados do segundo funcionário");
            Console.Write("Nome: ");

            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.Salario + f2.Salario) / 2;


            Console.WriteLine("Salário médio = "+ media.ToString("f2", CultureInfo.InvariantCulture));


        }
    }
}
