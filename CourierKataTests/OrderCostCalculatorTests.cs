using NUnit.Framework;
using CourierKata;

namespace CourierKataTests
{
    public class OrderCostCalculatorTests
    {
        [Test]
        public void ShouldCalculateCostForASingleParcel()
        {
            var width = 1;
            var length = 1;
            var height = 1;

            var calculator = new OrderCostCalculator();

            var result = calculator.CalculateCost(width, length, height);

            Assert.AreEqual(3.00, result.TotalCost);
        }
    }
}
