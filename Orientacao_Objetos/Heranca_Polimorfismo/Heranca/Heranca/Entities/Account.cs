using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    class Account
    {
        public int Number { get; private set; } // outras classes acessam, mas nõa podem modificar
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        // construtores
        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        // métodos
        public void WithDraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
