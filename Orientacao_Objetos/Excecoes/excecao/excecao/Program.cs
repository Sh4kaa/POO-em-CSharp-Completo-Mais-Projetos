using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excecao
{
    class Program
    {
        static void Main(string[] args)
        {
            try // bloco try
            {
                
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException) // bloco catch
            {
                Console.WriteLine("Division by zero is not allowed");
            }
            catch (FormatException e) // bloco catch 2
            {
                Console.WriteLine("Format error! " + e.Message);
            }
        }
    }
}
