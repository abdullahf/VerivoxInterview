using Verivox_Interview.Models;

namespace Verivox_Interview.Services
{
    public interface ITeriffService
    {
        public List<Teriff> GetCostModel(int annualConsumption);
    }
}
