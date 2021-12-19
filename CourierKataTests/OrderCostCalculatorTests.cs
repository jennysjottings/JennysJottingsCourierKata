using NUnit.Framework;
using CourierKata;
using System.Linq;

namespace CourierKataTests
{
    public class OrderCostCalculatorTests
    {
        [TestCase(1, 1, 1, 3)]
        [TestCase(1, 5, 5, 8)]
        [TestCase(4, 4, 4, 15)]
        [TestCase(10, 4, 4, 25)]
        public void ShouldCalculateCostForASingleParcelBasedOnSize(int width, int length, int height, decimal cost)
        {
            var calculator = new OrderCostCalculator();

            var result = calculator.CalculateCost(width, length, height);

            Assert.AreEqual(cost, result.TotalCost);
        }

        [Test]
        public void ShouldIncludeCollectionOfItemsWithIndividualCostAndDescriptionInResult()
        {
            var calculator = new OrderCostCalculator();

            var result = calculator.CalculateCost(1, 1, 1);

            Assert.AreEqual(1, result.Items.Count());
            Assert.AreEqual(3, result.Items.First().Cost);
            Assert.AreEqual("Small Parcel", result.Items.First().Description);
        }

        [Test]
        public void SpeedyShippingShouldBeIncludedAsItem()
        {
            var calculator = new OrderCostCalculator();

            var result = calculator.CalculateCost(1, 1, 1, true);

            Assert.AreEqual(2, result.Items.Count());
        }

        [TestCase(1, 1, 1, 3)]
        [TestCase(1, 5, 5, 8)]
        [TestCase(4, 4, 4, 15)]
        [TestCase(10, 4, 4, 25)]
        public void SpeedyShippingShouldDoubleCostOfOrderWithoutAffectingOtherItems(int width, int length, int height, decimal cost)
        {
            var calculator = new OrderCostCalculator();

            var result = calculator.CalculateCost(width, length, height, true);

            Assert.AreEqual(cost * 2, result.TotalCost);
            Assert.AreEqual(cost, result.Items.Single(x => !x.Description.ToLower().Equals("speedy shipping")).Cost);
        }
    }
}
