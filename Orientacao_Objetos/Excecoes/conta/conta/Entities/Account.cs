using conta.Entities.Exceptions;

namespace conta.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double WithDrawLimit { get; set; }
        public double Balance { get; set; }

        public Account(int number, string holder, double withDrawLimit, double balance)
        {
            Number = number;
            Holder = holder;
            WithDrawLimit = withDrawLimit;
            Balance = balance;
        }

        public void  Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithDrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }

            Balance -= amount;
        }

    }
}
