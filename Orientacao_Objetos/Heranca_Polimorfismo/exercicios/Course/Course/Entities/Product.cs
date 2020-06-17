using System.Globalization;

namespace Course.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        //métodos
        public virtual string PriceTag()
        {
            return Name + " $ " + Price.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
