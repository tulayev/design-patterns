namespace ProxyPattern.Services
{
    internal interface IPaymentService
    {
        bool ProcessPayment(string userId, decimal amount);
        decimal GetBalance(string userId);
    }
}
