using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introdLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source

            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define the query expression
            
            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10); // "where" serve para filtrar os dados atrendendo ao predicato
            //select serve para selecionar os novos elementos gerados pelço filtro do "where"

            // Execute the query

            foreach(int x in result)
            {
                Console.WriteLine(x);
            }

            // obs: a variável result é do tipo IEnumerable que é um tipo mais genérico de coleção e comtempla varios outros tipos de coleções

        }

    }
}
