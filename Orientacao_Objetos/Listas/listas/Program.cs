using System;
using System.Collections.Generic;


namespace listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("joazinho");
            lista.Add("Anazinha");
            lista.Insert(2, "Bob"); // inserir elementos na lista em uma posição especifica

            foreach(string obj in lista) // varrer a lista
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Tamanho da lista é: "+ lista.Count); // mostrar quantidade da lista

            string s1 = lista.Find(Test); // usando uam função como parametro pa identificar a primeira ocorrencia na lista que comece com 'A'
                                          //poderiamos usar a expressão lambda que seria "lista.Find(x => x[0] == 'A');"

            Console.WriteLine("First 'A': "+ s1);

            string s2 = lista.FindLast(y => y[0] == 'A'); // busca ultima ocorrencia no vetor que comece com 'A'

            Console.WriteLine("Last 'A': "+ s2);
            
        }
        static bool Test(string s)
        {
            return s[0] == 'A';
        }
    }
}
