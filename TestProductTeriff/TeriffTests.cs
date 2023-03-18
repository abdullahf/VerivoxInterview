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
            Assert.Throws<ArgumentNullException>(() => new ProductA("", 0));
            Assert.Throws<ArgumentException>(() => new ProductA(packageName, -1));
            Assert.IsTrue(new ProductA(packageName, 0).CalculateAnnualCost() == 60);
            Assert.IsTrue(new ProductA(packageName, 3500).CalculateAnnualCost() == 830);
            Assert.IsTrue(new ProductA(packageName, 4500).CalculateAnnualCost() == 1050);
            Assert.IsTrue(new ProductA(packageName, 6000).CalculateAnnualCost() == 1380);
        }

        [Test]
        public void ProductBTeriffTest()
        {
            var packageName = "Packaged teriff";
            Assert.Throws<ArgumentNullException>(() => new ProductB("", 0));
            Assert.Throws<ArgumentException>(() => new ProductB(packageName, -1).CalculateAnnualCost());
            Assert.IsTrue(new ProductB(packageName, 0).CalculateAnnualCost() == 800);
            Assert.IsTrue(new ProductB(packageName, 3500).CalculateAnnualCost() == 800);
            Assert.IsTrue(new ProductB(packageName, 4500).CalculateAnnualCost() == 950);
            Assert.IsTrue(new ProductB(packageName, 6000).CalculateAnnualCost() == 1400);
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