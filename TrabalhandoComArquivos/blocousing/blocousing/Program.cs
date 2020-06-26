using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blocousing
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";
            try
            {

                using (StreamReader sr = File.OpenText(path)) // estanciando e passando "fs" de parametro
                {
                    while (!sr.EndOfStream) // enquando a stream não chegar no final faça isso
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            // utilizando o bloco using ele já finaliza os objetos "sr" e "fs"
        }
    }
}
