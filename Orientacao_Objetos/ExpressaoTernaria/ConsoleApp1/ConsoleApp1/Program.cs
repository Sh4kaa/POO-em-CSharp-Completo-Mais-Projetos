using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine());
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05; // resolvido com expressão ternaria
            
            /*
            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }
            modo if e else*
            método if e esle para resolver a questão*/

            Console.WriteLine(desconto);
        }
    }
}
