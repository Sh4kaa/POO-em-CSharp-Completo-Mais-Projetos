

namespace exercContratoEmpresa.Services
{
    class PayPalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double Interest(double amount, int months) // juros
        {
            return amount * MonthlyInterest * months; // quantia vezes jurosMes * quantidade de meses
        }

        public double PaymentFee(double amount) // taxa de juros
        {
            return amount * FeePercentage; // quantia vezes percentualTaxa
        }
    }
}
