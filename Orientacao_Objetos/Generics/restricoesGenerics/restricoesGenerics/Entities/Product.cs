using System;
using System.Globalization;

namespace restricoesGenerics.Entities
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }


        public override string ToString()
        {
            return Name
                + ", "
                + Price.ToString("f2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Product)) // se obj não é um produto
            {
                throw new ArgumentException("Compare error: argument not Product");
            }
            Product other = obj as Product; // downcasting da superclasse obj para classe produto, convertendo para produto
            return Price.CompareTo(other.Price);
        }
    }
}
