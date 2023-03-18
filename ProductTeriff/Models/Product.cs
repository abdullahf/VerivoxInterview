namespace Verivox_Interview.Models
{
    public abstract class Product
    {
        public string Name { get; set; }

        // Base cost in euro
        public double BaseCost { get; set; }

        // Per kWh cost in cents
        public double PerKWhCost { get; set; }

        public Product(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Proudct name cannot be null or empty");

            Name = name;
        }

        public abstract Teriff CalculateAnnualCost(int consumption);
    }
}
