using System.Collections.Generic;
using System.Linq;

namespace CourierKata
{
    public record OrderCostResult
    {
        public decimal TotalCost => Items.Sum(x => x.Cost);
        public IEnumerable<OrderItem> Items { get; private set; }

        public OrderCostResult(IEnumerable<OrderItem> orderItems)
        {
            Items = orderItems;
        }

        // TODO: Could use decorator pattern to have an OrderCostResult that applies speedy shipping, then wouldn't need the AddSpeedyShipping method
        public void AddSpeedyShipping()
        {
            Items = Items.Concat(new[] { new OrderItem(TotalCost, "Speedy Shipping") });
        }
    }
}
