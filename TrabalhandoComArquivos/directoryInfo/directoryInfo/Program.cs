using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Policy;

namespace directoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder";
            try
            {
               IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); //enumerando os diretórios, passando o caminho, filtro de busca"*.*" e o tipo de de busca
                // obs: na hora de atribuir toda essa busca em uma variável é possivel declarar o tipo de varivel como "var" que os istema vai inferir o tipo necessario de variavel automaticamente
                Console.WriteLine("FOLDERS:");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); //enumerando os diretórios, passando o caminho, filtro de busca"*.*" e o tipo de de busca
                // obs: na hora de atribuir toda essa busca em uma variável é possivel declarar o tipo de varivel como "var" que os istema vai inferir o tipo necessario de variavel automaticamente
                // Alldirectories pesquisas nas subpastas
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\newfolder"); // criando uma pasta(obs:inves de usar o "@", é possivel usar "\\")
            }
            catch(IOException e)
            {
                Console.WriteLine("A error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
