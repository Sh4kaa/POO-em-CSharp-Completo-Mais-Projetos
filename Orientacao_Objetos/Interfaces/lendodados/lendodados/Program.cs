using System;
using System.Collections.Generic;
using System.IO;


namespace lendodados
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\teste.txt"; // definindo caminho de um arquivo existente e atribuindo em uam variavel

            using (StreamReader str = File.OpenText(path)) // utilizando o bloco "using" chamando streamreader para ler e chamando a função para ler e pssando o caminho
            {
                List<string> listastr = new List<string>(); // estanciando uma lista vazia
                while (!str.EndOfStream) // enquando o objeto "str" naõ chega no final da stream faça:
                {
                    listastr.Add(str.ReadLine()); //lendo e e adicionando o objeto str na lista
                }
                listastr.Sort(); // ordenando a lista por ordem alfabética
                foreach(string lista in listastr) //varrendo a lista
                {
                    Console.WriteLine(lista); // mostrando a lista
                }
            }
        }
    }
}
