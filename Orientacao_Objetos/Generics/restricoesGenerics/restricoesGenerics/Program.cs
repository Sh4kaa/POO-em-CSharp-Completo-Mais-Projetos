using restricoesGenerics.Entities;
using restricoesGenerics.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace restricoesGenerics
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>(); // criando lista vazia
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            // criando "for" para adicionar elementos nessa lista vazia
            for(int i = 0; i < n; i++) 
            {
                string[] vect = Console.ReadLine().Split(','); // lendos os elementos(produtos), separando posições removendo as virgulas
                //pegando as posições que foram separadas pelo split e adicionando nas variaveis de acordo com o tipo
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price)); // adicionando os produtos
            }

            CalculationService cal = new CalculationService(); // estanciando a classe de service que faz o calculo
            Product max = cal.Max(list); // criando variavel do tipo Product e chamando a função do calculationsservice que faz o calculo do-
                                         // preco maior de um produto e atribuindo na variavel do tipo produto 
            Console.WriteLine("Max: ");
            Console.WriteLine(max); // mostrando o resultado


        }
    }
}
