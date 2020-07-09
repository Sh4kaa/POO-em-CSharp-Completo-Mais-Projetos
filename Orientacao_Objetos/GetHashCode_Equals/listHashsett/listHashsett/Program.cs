using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listHashsett
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("Henri");
            set.Add("Dario");

            Console.WriteLine(set.Contains("Henri"));

            foreach(string set1 in set)
            {
                Console.WriteLine(set1);
            }

        }
    }
}
