namespace Verivox_Interview.Models
{
    public class ProductA : Product
    {
        public ProductA(string name) : base(name)
        {
            BaseCost = 5;
            PerKWhCost = 22;
        }

        public override Teriff CalculateAnnualCost(int consumption)
        {
            if (consumption < 0)
                throw new ArgumentException($"Product {Name}: Consumption cannot be negative");

            return new Teriff
            {
                Name = Name,
                AnnualCost = Math.Round(BaseCost * 12 + (PerKWhCost * consumption) / 100, 2),
            };
        }
    }
}
