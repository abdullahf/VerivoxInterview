namespace Verivox_Interview.Models
{
    public class ProductA : IProduct
    {
        public string Name { get; private set; }
        public double BaseCost { get; private set; }
        public double PerKWhCost { get; private set; }
        public int AnnualConsumption { get; private set; }
        public double AnnualCost { get; private set; }

        public ProductA(string name, int consumption, double baseCost = 5, double perKWhCost = 22)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Proudct name cannot be null or empty");

            if (consumption < 0)
                throw new ArgumentException($"Product {Name}: Consumption cannot be negative");

            BaseCost = baseCost;
            PerKWhCost = perKWhCost;
            AnnualConsumption = consumption;
            Name = name;
        }

        public double CalculateAnnualCost()
        {
            AnnualCost = Math.Round(BaseCost * 12 + (PerKWhCost * AnnualConsumption) / 100, 2);

            return AnnualCost;
        }
    }
}
