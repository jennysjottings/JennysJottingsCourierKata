using System.Collections.Generic;

namespace CourierKata
{
    public record OrderCostResult
    {
        public decimal TotalCost { get; }
        public IEnumerable<OrderItem> Items { get; }

        public OrderCostResult(decimal totalCost, IEnumerable<OrderItem> orderItems)
        {
            TotalCost = totalCost;
            Items = orderItems;
        }
    }
}
