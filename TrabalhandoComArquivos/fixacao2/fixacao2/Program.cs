using fixacao2.Entities;
using System;
using System.Globalization;
using System.IO;


namespace exercicio32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digita o caminho completo");
            string caminho = Console.ReadLine(); // caminho completo do arquivo(com nome do arquivo junto)

            try
            {
                string[] lines = File.ReadAllLines(caminho); // lendo o conteudo dentro desse diretório

                string nomedaPasta = Path.GetDirectoryName(caminho); // obtendo o nome da pasta onde o arquivo se encontra
                string novaPasta = nomedaPasta + @"\out"; // novo caminho
                string novoArquivo = novaPasta + @"\summary.csv";

                Directory.CreateDirectory(novaPasta);

                using (StreamWriter sw = File.AppendText(novoArquivo)) //adicionando novas informações nesse arquivo(caso tenha informações, adiciona ao final)
                {
                    foreach (string linha in lines)
                    {
                        string[] campos = linha.Split(','); // removendo todos os campos com virgula do texto
                        string name = campos[0];
                        double preco = double.Parse(campos[1], CultureInfo.InvariantCulture);
                        int quantidade = int.Parse(campos[2]);

                        Produto prod = new Produto(name, preco, quantidade);
                        sw.WriteLine(prod.Nome.ToString() + " " + prod.Total().ToString("f2", CultureInfo.InvariantCulture));
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
