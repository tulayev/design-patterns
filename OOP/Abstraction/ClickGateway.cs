namespace OOP.Abstraction
{
    internal class ClickGateway : IPaymentGateway
    {
        public bool Charge(string customerId, decimal amount)
        {
            Console.WriteLine($"[Click] Charging {amount:0.00} UZS to {customerId}");
            return true; // hides Click SDK complexity
        }
    }
}
