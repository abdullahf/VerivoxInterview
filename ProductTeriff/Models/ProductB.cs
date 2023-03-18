namespace Verivox_Interview.Models
{
    public class ProductB : Product
    {
        // Per kWh cost in kWh
        public double BaseConsumption { get; set; }

        public ProductB(string name) : base(name)
        {
            BaseCost = 800;
            BaseConsumption = 4000;
            PerKWhCost = 30;
        }

        public override Teriff CalculateAnnualCost(int consumption)
        {
            if (consumption < 0)
                throw new ArgumentException($"Product {Name}: Consumption cannot be negative");

            var annualCost = 0d;

            if (consumption <= BaseConsumption)
            {
                annualCost = BaseCost;
            }
            if (consumption > BaseConsumption)
            {
                annualCost = Math.Round(BaseCost + ((consumption - BaseConsumption) * PerKWhCost) / 100, 2);
            }

            return new Teriff
            {
                Name = Name,
                AnnualCost = annualCost
            };
        }
    }
}
