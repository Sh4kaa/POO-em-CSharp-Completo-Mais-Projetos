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
        public  virtual void WithDraw(double amount) // com virtual é possivel sobrescrever esse método em subclasses
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
