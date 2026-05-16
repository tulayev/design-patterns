namespace OOP.Abstraction
{
    internal class PaymeGateway : IPaymentGateway
    {
        public bool Charge(string customerId, decimal amount)
        {
            Console.WriteLine($"[Payme] Charging {amount:0.00} UZS to {customerId}");
            return true; // hides Payme SDK complexity
        }
    }
}
