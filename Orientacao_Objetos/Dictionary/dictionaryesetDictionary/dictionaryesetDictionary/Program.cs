using System;
using System.Collections.Generic;


namespace dictionaryesetDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            // cookies.Add("phone", "9868789576"); um dos jeitos de adicionar uma chave e seu valor
            
            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99771122";
            cookies["phone"] = "99771133";
           
            Console.WriteLine(cookies["email"]);
            cookies.Remove("email"); // removendo chave phone
            Console.WriteLine("Phone number: " + cookies["phone"]);
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine("Email: " + cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is not 'email' key");
            }

            Console.WriteLine("Size: " + cookies.Count);
            Console.WriteLine("ALL COOKIES:");
            foreach (KeyValuePair<string, string> item in cookies) // varrendo coleção (obs: onde está o tipo de item que será percorrido no foreach
                                                                   // pode-se colocar um "var" pra ficar menos verboso o código
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
