using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBanco
{
    class ContaBancaria
    {
        public int Numero;
        public string Titular;
        public double Saldo;

        
        
        // construtor
        public ContaBancaria(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
    }
}
