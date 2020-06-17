using System;
using System.Globalization;


namespace Course.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        // construtores
        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        //métodos
        public override string PriceTag()
        {
            return Name
                + " (used) $ "
                + Price.ToString("f2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + ManufactureDate.ToString("dd/MM/yyy")
                + ")";

        }

    }
}
