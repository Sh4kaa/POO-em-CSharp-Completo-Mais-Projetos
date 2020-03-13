using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matexercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            string[] s = Console.ReadLine().Split(' ');
            Console.WriteLine("------------");

            m = int.Parse(s[0]);
            n = int.Parse(s[1]);

            int[,] mat = new int[m, n];


            for (int i = 0; i < m; i++)
            {
                string[] numbers = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(numbers[j]);
                }
            }
            Console.WriteLine();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    if (num == mat[i, j])
                    {
                        Console.Write("Position " + i + "," + j + ";");
                    }
                }
                Console.WriteLine();

            }
            


        }
    }
}
