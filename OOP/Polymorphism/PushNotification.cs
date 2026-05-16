namespace OOP.Polymorphism
{
    internal class PushNotification : Notification
    {
        public override void Send(string message)
        {
            Console.WriteLine($"[Push] {message}");
        }
    }
}
