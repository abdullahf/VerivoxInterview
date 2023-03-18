namespace Verivox_Interview.Models
{
    public class ProductB : IProduct
    {
        public string Name { get; private set; }
        public double BaseCost { get; private set; }
        public double PerKWhCost { get; private set; }
        public int AnnualConsumption { get; private set; }
        public double AnnualCost { get; private set; }

        private const int BaseConsumption = 4000;

        public ProductB(string name, int consumption, double baseCost = 800, double perKWhCost = 30)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Proudct name cannot be null or empty");

            if (consumption < 0)
                throw new ArgumentException($"Product {Name}: Consumption cannot be negative");

            BaseCost = baseCost;
            PerKWhCost = perKWhCost;
            AnnualConsumption = consumption;
            Name = name;
            AnnualCost = baseCost;
        }

        public double CalculateAnnualCost()
        {
            if (AnnualConsumption <= BaseConsumption)
            {
                AnnualCost = BaseCost;
            }
            if (AnnualConsumption > BaseConsumption)
            {
                AnnualCost = Math.Round(BaseCost + ((AnnualConsumption - BaseConsumption) * PerKWhCost) / 100, 2);
            }

            return AnnualCost;
        }
    }
}
