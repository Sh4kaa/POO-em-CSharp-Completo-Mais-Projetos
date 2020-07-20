using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioResolvidoDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {


                using(StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> votacao = new Dictionary<string, int>();
                    while (!(sr.EndOfStream))
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string candidato = line[0];
                        int voto = int.Parse(line[1]);



                        if (votacao.ContainsKey(candidato)) // passando a key "candidato"
                        {
                            votacao[candidato] += voto; // o dictionary "votacao" na chave "candidato" recebe o voto(tipo int)
                        }
                        else
                        {
                            votacao[candidato] = voto;
                        }
                    }

                    foreach(KeyValuePair<string, int> votCand in votacao) // poderia usar tbem  o "var" no lugar de "KeyValuePair" para ficar menos verboso
                    {
                        Console.WriteLine(votCand.Key +":"+ " "+ votCand.Value );
                    }
                    //obs: chave recebe um apelido, no caso "canditato"(tipo string)

                }


            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
