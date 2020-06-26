using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streamwriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt"; // caminho
            string targetPath = @"c:\temp\file2.txt"; // destino
            try
            {
                string[] lines = File.ReadAllLines(sourcePath); // string recebendo a leitura do arquivo de origem
                using (StreamWriter sw = File.AppendText(targetPath)) // bloco using estanciando streamwriter(escrever no arquivo) com função para escrever no final do texto do arquivo(concatena)
                {
                    foreach(string line in lines) // varrendo os caracteres do arquivo de origem
                    {
                        sw.WriteLine(line.ToUpper()); // escrevendo no arquivo de destino com letra maiscula
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
