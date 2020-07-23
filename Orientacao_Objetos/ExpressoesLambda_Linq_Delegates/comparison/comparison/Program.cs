using comparison.Entities;
using System;
using System.Collections.Generic;


namespace comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));


            list.Sort(ComparisonProd); // modo 2 passanos referencia de método
            

            foreach(Product prod in list)
            {
                Console.WriteLine(prod);
            }
        }
        static int ComparisonProd(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }

    }
}
