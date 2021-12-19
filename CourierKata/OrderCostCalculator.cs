namespace CourierKata
{
    public class OrderCostCalculator
    {
        public OrderCostResult CalculateCost(int width, int length, int height)
        {
            return new OrderCostResult(3, new[] { new OrderItem(3) });
        }
    }
}
