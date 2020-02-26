using System;


namespace quartospensao
{
    class Program
    {
        static void Main(string[] args)
        {
            Pensao[] vetquart = new Pensao[9];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();            

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Aluguel #" + (i + 1)+":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vetquart[i] = new Pensao { Nome = nome, Email = email, Quarto = quarto };

                Console.WriteLine();
                
            }


            Console.WriteLine("Quartos ocupados:");
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vetquart[i].Quarto + ":" + " " + vetquart[i].Nome + ", " + " " + vetquart[i].Email);
            }
            Console.WriteLine();
        }
    }
}
