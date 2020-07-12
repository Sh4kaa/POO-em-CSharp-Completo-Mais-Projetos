using System;
using System.Collections.Generic;


namespace CursoOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();



            Console.Write("How many students for course A? ");
            int quantAlunos = int.Parse(Console.ReadLine());
            int matricula;
            
            for(int i = 0; i < quantAlunos; i++)
            {
                matricula = int.Parse(Console.ReadLine());
                A.Add(matricula);
            }

            Console.Write("How many students for course B? ");
            quantAlunos = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < quantAlunos; i++)
            {
                matricula = int.Parse(Console.ReadLine());
                B.Add(matricula);
            }

            Console.Write("How many students for course C? ");
            quantAlunos = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantAlunos; i++)
            {
                matricula = int.Parse(Console.ReadLine());
                C.Add(matricula);
            }


            A.UnionWith(B);
            A.UnionWith(C);



            Console.WriteLine("Total students: "+ A.Count);




        }
    }
}
