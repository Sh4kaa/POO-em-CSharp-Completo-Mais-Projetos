using System;
using System.Globalization;
using System.IO;


namespace exerfixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine(); // lendo caminho do arquivo

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath); // lendo o conteudo desse arquivo

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath); // obtendo as informações do caminho do arquivo
                string targetFolderPath = sourceFolderPath + @"\out"; // atribuindo as informações do caminho do arquivo a uma variavel acrescentando mais uma pasta no caminho
                string targetFilePath = targetFolderPath + @"\summary.csv"; // atribuindo o novo caminho gerado a uma variavel com 1 arquivo nas pasta final

                Directory.CreateDirectory(targetFolderPath); // criando novo diretório com base no novo caminho "out"

                using (StreamWriter sw = File.AppendText(targetFilePath)) // lendo o novo arquivo criado
                {
                    foreach (string line in lines) // varrendo o conteudo do arquivo gerado
                    {
                        // removendo as virgulas do conteudo desse arquivo e atribuindo as novas posições e instanciando as informações para a classe
                        string[] fields = line.Split(','); 
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Produto prod = new Produto(name, price, quantity);

                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
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
