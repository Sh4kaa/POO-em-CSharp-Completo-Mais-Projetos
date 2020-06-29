using System.Globalization;
namespace aluguelcarro.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }
        public double TotalPayment // propriedade calculada
        {
            get
            {
                return BasicPayment + Tax;
            }
        }

        public override string ToString()
        {
            return "Basic payment: "
                + BasicPayment.ToString("f2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("f2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + TotalPayment.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
