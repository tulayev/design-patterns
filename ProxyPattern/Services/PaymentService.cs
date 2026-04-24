namespace ProxyPattern.Services
{
    internal class PaymentService : IPaymentService
    {
        private readonly Dictionary<string, decimal> _balances = new()
        {
            { "user1", 1000m },
            { "user2", 500m }
        };

        public bool ProcessPayment(string userId, decimal amount)
        {
            if (!_balances.ContainsKey(userId) || _balances[userId] < amount)
            {
                return false;
            }

            _balances[userId] -= amount;
            Console.WriteLine($"[{nameof(PaymentService)}] Payment of {amount:C} processed for {userId}.");

            return true;
        }

        public decimal GetBalance(string userId)
        {
            return _balances.TryGetValue(userId, out var balance) ? balance : 0m;
        }
    }
}
