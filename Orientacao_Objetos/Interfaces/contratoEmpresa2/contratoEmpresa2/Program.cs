using System;
using contratoEmpresa2.Entities;
using System.Globalization;
using contratoEmpresa2.Services;

namespace contratoEmpresa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do contrato:");
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do contrato: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Digite o numero de prestações: ");
            int prestacoes = int.Parse(Console.ReadLine());
            

            Contrato contrato = new Contrato(numero, data, valor);
            ServicoDeContrato servicoDeContrato = new ServicoDeContrato(new ServicoPayPal());
            servicoDeContrato.ProcessarContrato(contrato, prestacoes);

            Console.WriteLine("Parcelas:");

            foreach(Prestacoes prest in contrato.Prestacoes)
            {
                Console.WriteLine(prest);
            }

        }
    }
}
