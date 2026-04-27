using AdapterPattern.Logger;

namespace AdapterPattern.Services
{
    internal class OrderService
    {
        private readonly ILogger _logger;

        public OrderService(ILogger logger)
        {
            _logger = logger;
        }

        public void PlaceOrder(string product, int quantity)
        {
            _logger.LogInfo($"Placing order: {quantity}x {product}");

            if (quantity > 100)
            {
                _logger.LogWarning("Large order — requires approval.");
            }

            if (quantity <= 0)
            {
                _logger.LogError("Invalid quantity. Order rejected.");
                return;
            }

            _logger.LogInfo($"Order confirmed for {product}.");
        }
    }
}
