using System;


namespace quartospensao
{
    class Program
    {
        static void Main(string[] args)
        {
            Pensao[] vetquart = new Pensao[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vetquart[quarto] = new Pensao(nome, email);

                Console.WriteLine();

            }


            Console.WriteLine("Quartos ocupados:");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                if (vetquart[i] != null)
                {
                    Console.WriteLine(i + ": " + vetquart[i]);
                }

            }
            Console.WriteLine();
        }
    }
}
