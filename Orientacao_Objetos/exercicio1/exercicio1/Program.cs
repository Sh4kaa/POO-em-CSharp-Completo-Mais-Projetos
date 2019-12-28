using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas p1 = new Pessoas(); // estanciando o objeto da classe Pessoas
            Pessoas p2 = new Pessoas();


            // dados da primeira pessoa, nome e idade
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine(); // chamando e lendo o objeto nome da classe pessoas
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            // dados da segunda pessoa

            Console.WriteLine("Dados da segunda pessoa;");
            Console.Write("Nome: ");

            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if(p2.Idade > p1.Idade)
            {
                Console.WriteLine("A pessoa mais velha é " + p2.Nome);
            } else
            {
                Console.WriteLine("A pessoa mais velha é " + p1.Nome);
            }


            



        }
    }
}
