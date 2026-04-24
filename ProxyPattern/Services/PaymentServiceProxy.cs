namespace ProxyPattern.Services
{
    internal class PaymentServiceProxy : IPaymentService
    {
        private readonly IPaymentService _realService;
        private readonly HashSet<string> _authorizedUsers = ["user1"];

        public PaymentServiceProxy(IPaymentService realService)
        {
            _realService = realService;
        }

        public bool ProcessPayment(string userId, decimal amount)
        {
            // Authorization check
            if (!_authorizedUsers.Contains(userId))
            {
                Console.WriteLine($"[Proxy] BLOCKED: User '{userId}' is not authorized.");
                return false;
            }

            // Pre-call logging
            Console.WriteLine($"[Proxy] Initiating payment of {amount:C} for user '{userId}'...");

            var result = _realService.ProcessPayment(userId, amount);

            // Post-call logging
            Console.WriteLine($"[Proxy] Payment result: {(result ? "SUCCESS" : "FAILED")}");

            return result;
        }

        public decimal GetBalance(string userId)
        {
            Console.WriteLine($"[Proxy] Fetching balance for user '{userId}'...");
            var balance = _realService.GetBalance(userId);
            Console.WriteLine($"[Proxy] Balance retrieved: {balance:C}");

            return balance;
        }
    }
}
