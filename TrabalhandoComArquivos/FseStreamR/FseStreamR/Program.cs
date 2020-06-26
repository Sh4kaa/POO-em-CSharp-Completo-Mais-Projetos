using System;
using System.IO;

namespace FseStreamR
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";
            //FileStream fs = null; //(JEITO 1 DE FAZER)
            StreamReader sr = null;
            try
            {
                //fs = new FileStream(path, FileMode.Open); // caminho do arquivo e abre o arquivo (JEITO 1 DE FAZER)
                // sr = new StreamReader(fs); // leitura do arquivo (JEITO 1 DE FAZER)
                sr = File.OpenText(path); //jeito 2 de fazer
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine(); // jogando a leitura na string "line"
                    Console.WriteLine(line);
                }

                
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close(); // como o clr naõ é gerenciado pelo dot net é necessario fechar o arquivo
                // if (fs != null) fs.Close();  // como o clr naõ é gerenciado pelo dot net é necessario fechar o arquivo

            }
        }
    }
}
