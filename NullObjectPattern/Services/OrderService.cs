internal class OrderService
{
    private readonly ILogger _logger;

    // If no logger provided, use NullLogger — never null
    public OrderService(ILogger? logger = null)
    {
        _logger = logger ?? new NullLogger();
    }

    public void PlaceOrder(string product, int quantity)
    {
        _logger.LogInfo($"Placing order: {quantity}x {product}");

        if (quantity <= 0)
        {
            _logger.LogError("Invalid quantity.");
            return;
        }

        if (quantity > 100)
        {
            _logger.LogWarning("Large order — needs approval.");
        }

        _logger.LogInfo($"Order confirmed: {product}");
    }
}
