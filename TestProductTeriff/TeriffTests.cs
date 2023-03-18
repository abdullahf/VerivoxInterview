using Verivox_Interview.Models;
using Verivox_Interview.Services;

namespace TestVerivox
{
    public class TeriffTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ProductATeriffTest()
        {
            var packageName = "Basic electricity teriff";
            Assert.Throws<ArgumentNullException>(() => new ProductA(""));
            Assert.Throws<ArgumentException>(() => new ProductA(packageName).CalculateAnnualCost(-1));
            Assert.IsTrue(new ProductA(packageName).CalculateAnnualCost(0).AnnualCost == 60);
            Assert.IsTrue(new ProductA(packageName).CalculateAnnualCost(3500).AnnualCost == 830);
            Assert.IsTrue(new ProductA(packageName).CalculateAnnualCost(4500).AnnualCost == 1050);
            Assert.IsTrue(new ProductA(packageName).CalculateAnnualCost(6000).AnnualCost == 1380);
        }

        [Test]
        public void ProductBTeriffTest()
        {
            var packageName = "Packaged teriff";
            Assert.Throws<ArgumentNullException>(() => new ProductB(""));
            Assert.Throws<ArgumentException>(() => new ProductB(packageName).CalculateAnnualCost(-1));
            Assert.IsTrue(new ProductB(packageName).CalculateAnnualCost(0).AnnualCost == 800);
            Assert.IsTrue(new ProductB(packageName).CalculateAnnualCost(3500).AnnualCost == 800);
            Assert.IsTrue(new ProductB(packageName).CalculateAnnualCost(4500).AnnualCost == 950);
            Assert.IsTrue(new ProductB(packageName).CalculateAnnualCost(6000).AnnualCost == 1400);
        }

        [Test]
        public void SortOrderTest()
        {
            var teriffService = new TeriffService();

            var list = teriffService.GetCostModel(3500);

            Assert.IsTrue(list[0].AnnualCost == 800);
        }
    }
}