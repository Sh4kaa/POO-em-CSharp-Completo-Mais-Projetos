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
            string path = @"c:\temp\filex.txt";
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open)) // estanciando, passando o path, abrindo o arquivo
                {
                    using (StreamReader sr = new StreamReader(fs)) // estanciando e passando "fs" de parametro
                    {
                        while (!sr.EndOfStream) // enquando a stream não chegar no final faça isso
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            // utilizando o bloco using ele já finaliza os objetos "sr" e "fs"
        }
    }
}
