using System;
using System.IO;


namespace trabarquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath); // necessario estanciar
                fileInfo.CopyTo(targetPath); // copiando para o destino o arquivo

                string[] lines = File.ReadAllLines(sourcePath); // nõa precisa estanciar pois é estatica

                foreach(string line in lines) // varrendo vetor de lines
                {
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
