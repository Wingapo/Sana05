namespace Main
{
    internal class Product
    {
        public string Name { get; protected set; }
        public double Price { get; protected set; }
        public Currency Cost { get; }
        public int Quantity { get; protected set; }
        public string Producer { get; }
        public double Weight { get; }

        public Product()
        {
            Name = "name";
            Cost = new Currency();
            Producer = "producer";
        }

        public Product(string name, double price, Currency cost,
            int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product(string name, double price, Currency cost, int quantity, string producer)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
        }

        public Product(Product other)
        {
            Name = other.Name;
            Price = other.Price;
            Cost = other.Cost;
            Quantity = other.Quantity;
            Producer = other.Producer;
            Weight = other.Weight;
        }

        public double GetPriceInUAH()
        {
            return Price * Cost.ExRate;
        }

        public double GetTotalPriceInUAH()
        {
            return Quantity * this.GetPriceInUAH();
        }

        public double GetTotalWeight() 
        {
            return Quantity * Weight;
        }
    }
}
