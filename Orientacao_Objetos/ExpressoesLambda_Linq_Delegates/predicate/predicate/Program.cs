using predicate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));
            Func<Product, string> func = p => p.Name.ToUpper(); // expressão lâmbida

            // obs: não é necessario utilizar chaves, pois em expressão lambida não é necessari quanto se trata de returonar algum valor
            // assim como também poderia se utilizar as chaves, porém seria necessario utilizar o comando return
            // exemplo: Func<Product, string> func = p => { return  p.Name.ToUpper();};


            List<string> result = list.Select(func).ToList(); // um segunda lista recebendo o obj func que recebeu uma referencia de uma função 

            foreach(string s in result)
            {
                Console.WriteLine(s);
            }
        }
        
    }
}
