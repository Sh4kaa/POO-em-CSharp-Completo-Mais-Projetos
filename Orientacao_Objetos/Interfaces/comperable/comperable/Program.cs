using comperable.Entities;
using System;
using System.Collections.Generic;
using System.IO;


namespace comperable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\teste.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream) // varrendo as linhas até o final
                    {
                        list.Add(new Employee(sr.ReadLine())); // lendo e adicionando na lista de funcionarios
                    }
                    list.Sort(); // ordenando por nome
                    foreach (Employee emp in list) // varrendo a lista de funcionarios
                    {
                        Console.WriteLine(emp); // mostrando na tela
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
