
namespace aluguelcarro.Services
{
    class BrazilTaxService : ITaxService // obs:isso não é herança, é uma realização de interface
    {
        public double Tax(double amount)
        {
            if (amount <= 100.0)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
