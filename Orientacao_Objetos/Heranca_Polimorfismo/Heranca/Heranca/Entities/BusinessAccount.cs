
namespace Heranca.Entities
{
    class BusinessAccount : Account  // entenção da classe account que herda métodos e atributos
    {
        public double LoanLimit { get; set; }

        //contrutor padrão
        public BusinessAccount()
        {

        }

        // construtor com parametros e chamando outro construtor da superclasse
        public BusinessAccount(int number, string holder, double balance, double loanLimit)  // definindo parametros da classe Business
            :base(number, holder, balance) // chamando o contrutor da classe account
        {
            LoanLimit = loanLimit;
        }
         // métodos

        public void Loan(double amount)
        {
            if(LoanLimit <= amount)
            {
                Balance += amount;
            }
        }
    }
}
