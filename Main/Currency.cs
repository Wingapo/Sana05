namespace Main
{
    internal class Currency
    {
        public string Name { get; }
        public double ExRate { get; }

        public Currency()
        {
            Name = "usd";
            ExRate = 37.48;
        }

        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }

        public Currency(string name)
        {
            Name = name;
        }

        public Currency(Currency other) { 
            Name = other.Name;
            ExRate = other.ExRate;
        }
    }
}
