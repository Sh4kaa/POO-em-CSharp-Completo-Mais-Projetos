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
                        Console.WriteLine("Position " + i + "," + j + ";");
                        if (j > 0) // para imprimir o lado esquerdo a coluna tem que ser maior que 0(considerando que o numero selecionado seja no 0,0)
                        {

                            Console.WriteLine("Left: " + mat[i, j - 1]);

                        }
                        if (i > 0) // para imprimir o valor acima do numero da matriz selecionado considerando ele estando no zero a linah deve ser maior que 0
                        {

                            Console.WriteLine("Up: " + mat[i - 1, j]);

                        }
                        if (j < n - 1) // só imprime se a coluna "j" for menor que a ultima coluna - 1
                        {

                            Console.WriteLine("Right: " + mat[i, j + 1]);

                        }
                        if (i < m - 1) // só imprime se a linha for menor que a ultima linha - 1(supondo que esteja na ultima linha)
                        {

                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }

                    }
                    

                }



            }
        }
    }
}
