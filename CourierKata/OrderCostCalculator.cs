namespace CourierKata
{
    public class OrderCostCalculator
    {
        public OrderCostResult CalculateCost(int width, int length, int height)
        {
            var totalDimensions = width * length * height;
            decimal cost = 0;
            switch (totalDimensions)
            {
                case < 10:
                    cost = 3;
                    break;
                case < 50:
                    cost = 8;
                    break;
                case < 100:
                    cost = 15;
                    break;
                default:
                    cost = 25;
                    break;
            }
            return new OrderCostResult(new[] { new OrderItem(cost) });
        }
    }
}
