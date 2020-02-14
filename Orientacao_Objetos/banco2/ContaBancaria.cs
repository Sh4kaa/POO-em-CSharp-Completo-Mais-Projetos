﻿using System.Globalization;


namespace banco2
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo): this (numero, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public double Saque(double quantia)
        {
           return Saldo -= quantia + 5.00;
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", " + "Titular: " + Titular + ", " + "Saldo " + Saldo.ToString("f2",
                CultureInfo.InvariantCulture);
        }


    }
}
