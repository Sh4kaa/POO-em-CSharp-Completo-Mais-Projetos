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
            lista.Add("Bob");
            lista.Add("Anna");
            lista.Insert(2, "Marco"); // inserir elementos na lista em uma posição especifica

            //predicado tema  ver com função e envolve expressão lambda

            foreach(string obj in lista) // varrer a lista
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Tamanho da lista é: "+ lista.Count); // mostrar quantidade da lista

            string s1 = lista.Find(Test); // usando uam função como parametro pa identificar a primeira ocorrencia na lista que comece com 'A'
                                          //poderiamos usar a expressão lambda que seria "lista.Find(x => x[0] == 'A');"

            Console.WriteLine("First 'A': "+ s1);

            string s2 = lista.FindLast(y => y[0] == 'A'); // busca ultima ocorrencia na lista que comece com 'A'

            Console.WriteLine("Last 'A': "+ s2);

            int pos1 = lista.FindIndex(x => x[0] =='A'); // encontra a primeira posição do elemento da lista que contenha 'A (com base nas posições)

            Console.WriteLine("Fisrt position 'A': "+ pos1);

            int pos2 = lista.FindLastIndex(x => x[0] == 'A'); // encontra a ultima posição do elemento da lista que contenha o caractere 'A' (com base nas posiçõees)

            Console.WriteLine("Fisrt position 'A': " + pos2);


            List<string> list2 = lista.FindAll(x => x.Length == 5); /* gera uma nova lista com base na primeira, trazendo os
                                                                     elementos que contenham 5 caracteres*/
                      
            foreach(string obj2 in list2)
            {
                Console.WriteLine(obj2);
            }

            Console.WriteLine("--------------");

            lista.RemoveAt(3); // remove uma ocorrencia da posicao 3 da lista
            //lista.Remove("Alex"); remove apenas o alex
            // lista.RemoveRange(2, 2); remove a partir da posição 2 e remove mais 2 ocorrencias;


            foreach (string obj2 in lista)
            {
                Console.WriteLine(obj2);
            }

            Console.WriteLine("----------");

            lista.RemoveAll(x => x[0] == 'M'); // remove todas as ocorrencias que se iniciaim com 'M' da lista


            foreach (string obj2 in lista)
            {
                Console.WriteLine(obj2);
            }
                     
            

        }
        static bool Test(string s)
        {
            return s[0] == 'A';
        }
    }
}
