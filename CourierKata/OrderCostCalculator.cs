using System;

namespace CourierKata
{
    public class OrderCostCalculator
    {
        public OrderCostResult CalculateCost(int width, int length, int height, int weight, bool speedyShipping = false)
        {
            var totalDimensions = width * length * height;
            decimal cost = 0;
            decimal excessWeight = 0;
            string description = string.Empty;
            switch (totalDimensions)
            {
                // TODO: see comment on OrderItem re. having classes with this information built in
                case < 10:
                    cost = 3;
                    description = "Small Parcel";
                    excessWeight = Math.Max(weight, 1) - 1;
                    break;
                case < 50:
                    cost = 8;
                    description = "Medium Parcel";
                    excessWeight = Math.Max(weight, 3) - 3;
                    break;
                case < 100:
                    cost = 15;
                    description = "Large Parcel";
                    excessWeight = Math.Max(weight, 6) - 6;
                    break;
                default:
                    cost = 25;
                    description = "XL Parcel";
                    excessWeight = Math.Max(weight, 10) - 10;
                    break;
            }
            var excessWeightSurcharge = excessWeight * 2;
            var output = new OrderCostResult(new[] { new OrderItem(cost + excessWeightSurcharge, description) });
            if (speedyShipping)
            {
                output.AddSpeedyShipping();
            }
            return output;
        }
    }
}
