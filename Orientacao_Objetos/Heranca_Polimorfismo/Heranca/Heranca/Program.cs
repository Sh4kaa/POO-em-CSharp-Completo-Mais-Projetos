using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Dario", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            // account.Balance = 100.0; naõ é possivel acessar pois o atributo está protegido pelo modificador de acesso protecd
            // que só pode ser ACESSADO ou alterado PELA SUBCLASSE
        }
    }
}
