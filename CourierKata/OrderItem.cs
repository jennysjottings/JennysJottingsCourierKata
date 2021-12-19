
namespace CourierKata
{
    public class OrderItem
    {
        public decimal Cost { get; }
        public string Description { get; }

        public OrderItem(decimal cost, string description)
        {
            Cost = cost;
            Description = description;
        }
    }
}
