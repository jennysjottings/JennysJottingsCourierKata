namespace CourierKata
{
    public class OrderCostCalculator
    {
        public OrderCostResult CalculateCost(int width, int length, int height)
        {
            return new OrderCostResult(new[] { new OrderItem(3) });
        }
    }
}
