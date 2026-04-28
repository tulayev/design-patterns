namespace MediatorPattern
{
    internal class Mediator
    {
        public event EventHandler<int>? Alerts;

        public void Broadcast(object sender, int n)
        {
            Alerts?.Invoke(sender, n);
        }
    }
}
