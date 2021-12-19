namespace CourierKata
{
    public record OrderCostResult
    {
        public decimal TotalCost { get; }

        public OrderCostResult(decimal totalCost)
        {
            TotalCost = totalCost;
        }
    }
}
