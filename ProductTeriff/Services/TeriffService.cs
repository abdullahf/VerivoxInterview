using Verivox_Interview.Models;

namespace Verivox_Interview.Services
{
    public class TeriffService : ITeriffService
    {
        public TeriffService() { }

        public List<Teriff> GetCostModel(int annualConsumption)
        {
            return new List<Teriff>()
            {
                new ProductA("Basic electricity teriff").CalculateAnnualCost(annualConsumption),
                new ProductB("Packaged teriff").CalculateAnnualCost(annualConsumption),
            }.OrderBy(p => p.AnnualCost).ToList();
        }
    }
}
