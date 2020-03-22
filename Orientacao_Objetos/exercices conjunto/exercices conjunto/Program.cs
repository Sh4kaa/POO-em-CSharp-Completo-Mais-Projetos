using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices_conjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            // conjunto A
            Console.Write("O curso A possui quantos alunos? ");
            int QuantA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            
            for(int i = 0; i < QuantA; i++)
            {
                A.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine();

            //conjunto B
            Console.Write("O curso B possui quantos alunos? ");
            int QuantB = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B: ");

            for (int i = 0; i < QuantB; i++)
            {
                B.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine();

            //conjunto C
            Console.Write("O curso C possui quantos alunos? ");
            int QuantC = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C: ");

            for (int i = 0; i < QuantC; i++)
            {
                C.Add(int.Parse(Console.ReadLine()));
            }

            // unindo os conuntos A com B e C
            A.UnionWith(B);
            A.UnionWith(C);

            //varrendo o conjunto
            int cont = 0;
            foreach(int x in A)
            {
                cont++;
            }

            // saida dos dados
            Console.Write("Total de alunos: "+ cont);
            Console.WriteLine();





        }
    }
}
