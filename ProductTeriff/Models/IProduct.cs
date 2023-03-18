namespace Verivox_Interview.Models
{
    public interface IProduct
    {
        public string Name { get; }

        // Base cost in euro
        public double BaseCost { get; }

        // Per kWh cost in cents
        public double PerKWhCost { get; }

        public int AnnualConsumption { get; }

        public double AnnualCost { get; }

        public double CalculateAnnualCost();
    }
}
