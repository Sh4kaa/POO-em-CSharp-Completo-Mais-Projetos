using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedset
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() {  0, 2, 4, 5, 6, 8,10 }; // A
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 }; // B
            //PrintCollections(a);
            // union
            SortedSet<int> c = new SortedSet<int>(a);// pegando os elementos da coleção A e adicionando no C
            c.UnionWith(b); // unindo conjunto A com B (unindo os dois conjuntos sem repetir nenhum elemento(será adicionado no A novos elementos do B))
            PrintCollections(c); // mostrando na tela

            //intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b); // mostra os elementos que existem nos dois conjuntos

            PrintCollections(d);

            //difference
            SortedSet<int> e = new SortedSet<int>(a); // elementos de A que naõ existem no B
            e.ExceptWith(b);
            PrintCollections(e);


        }
        static void PrintCollections<T>(SortedSet<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
