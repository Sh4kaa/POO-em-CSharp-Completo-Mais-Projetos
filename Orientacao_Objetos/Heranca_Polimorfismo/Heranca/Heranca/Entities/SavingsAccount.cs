using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingsAccount()
        {

        }
        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void WithDraw(double amount) // sobrescrevendo o método de saque da superclasse(Account)
        {
            // Balance -= amount; // sem desconto
            base.WithDraw(amount); // saque com desconto de 5.0
            Balance -= 2.0; // saque adicionando mais 2.0 no total 7
        }

    }
}
