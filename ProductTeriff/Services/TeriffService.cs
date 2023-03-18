using Verivox_Interview.Models;

namespace Verivox_Interview.Services
{
    public class TeriffService : ITeriffService
    {
        public TeriffService() { }

        public List<Teriff> GetCostModel(int annualConsumption)
        {
            IProduct productA = new ProductA("Basic electricity teriff", annualConsumption);
            var annualCostA = productA.CalculateAnnualCost();

            IProduct productB = new ProductB("Packaged teriff", annualConsumption);
            var annualCostB = productB.CalculateAnnualCost();

            return new List<Teriff>()
            {
                new Teriff() { Name = productA.Name, AnnualCost = annualCostA },
                new Teriff() { Name = productB.Name, AnnualCost = annualCostB },
            }.OrderBy(p => p.AnnualCost).ToList();
        }
    }
}
