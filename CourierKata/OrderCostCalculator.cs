namespace CourierKata
{
    public class OrderCostCalculator
    {
        public OrderCostResult CalculateCost(int width, int length, int height)
        {
            var totalDimensions = width * length * height;
            decimal cost = 0;
            string description = string.Empty;
            switch (totalDimensions)
            {
                case < 10:
                    cost = 3;
                    description = "Small Parcel";
                    break;
                case < 50:
                    cost = 8;
                    description = "Medium Parcel";
                    break;
                case < 100:
                    cost = 15;
                    description = "Large Parcel";
                    break;
                default:
                    cost = 25;
                    description = "XL Parcel";
                    break;
            }
            return new OrderCostResult(new[] { new OrderItem(cost, description) });
        }
    }
}
