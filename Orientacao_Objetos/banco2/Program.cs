using System;
using System.Globalization;


namespace banco2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Haverá depósito inicial (s/n) ");
            char dep = char.Parse(Console.ReadLine());

            Console.WriteLine();


            if (dep == 's' || dep == 'S')
            {
                Console.Write("Entre um valor para depósito: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, deposito);
                
            } else
            {
                conta = new ContaBancaria(numero, titular);
            }
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Saque(saque);

            Console.WriteLine();


            Console.WriteLine("Dados da conta Atualizados: ");

            Console.WriteLine(conta);




        }
    }
}
