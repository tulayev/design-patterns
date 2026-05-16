namespace OOP.Polymorphism
{
    internal class EmailNotification : Notification
    {
        public override void Send(string message)
        {
            Console.WriteLine($"[Email] {message}");
        }
    }
}
