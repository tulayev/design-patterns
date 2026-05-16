namespace OOP.Abstraction
{
    internal interface IPaymentGateway
    {
        bool Charge(string customerId, decimal amount);
    }
}
