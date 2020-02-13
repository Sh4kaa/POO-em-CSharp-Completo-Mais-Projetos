using System;
using System.Globalization;


namespace exerciciobanco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria bank;

            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char depInicial = char.Parse(Console.ReadLine());

            Console.WriteLine();


            if (depInicial == 's' || depInicial == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double valInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                bank = new ContaBancaria(numeroConta, titular, valInicial);
            }
            else
            {
                bank = new ContaBancaria(numeroConta, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(bank);
            Console.WriteLine();

            Console.Write("Entre com o valor para déposito: ");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            bank.Deposito(dep);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(bank);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            bank.Saque(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine();

            Console.WriteLine(bank);
        }
    }
}
