
namespace CourierKata
{
    public class OrderItem
    {
        public decimal Cost { get; }
        public string Description { get; }

        // TODO: separate classes for the different order items that have their cost and description built in instead of passed in
        public OrderItem(decimal cost, string description)
        {
            Cost = cost;
            Description = description;
        }
    }
}
