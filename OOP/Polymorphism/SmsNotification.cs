namespace OOP.Polymorphism
{
    internal class SmsNotification : Notification
    {
        public override void Send(string message)
        {
            Console.WriteLine($"[SMS] {message}");
        }
    }
}
