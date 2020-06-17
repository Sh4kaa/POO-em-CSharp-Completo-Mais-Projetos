using System.Globalization;

namespace Course.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        // construtores
        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price) 
        {
            CustomsFee = customsFee;
        }

        // métodos
        public override string PriceTag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("f2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + CustomsFee.ToString("f2", CultureInfo.InvariantCulture)
                + ")";
        }

        public double TotalPrice()
        {
            return CustomsFee + Price;
        }


    }
}
