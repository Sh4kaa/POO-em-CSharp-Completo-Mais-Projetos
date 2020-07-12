namespace Course.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode(); // a soma de dois hashcode não dará a mesma se comparado com outro produto;
        }
        public override bool Equals(object obj)
        {
            if(!(obj is Product))
            {
                return false;
            }
            Product other = obj as Product; // downcast esse obj é um produto

            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}