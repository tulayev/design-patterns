namespace ChainOfResponsibilityPattern.Ticket.Handlers
{
    internal class ManagerHandler : SupportHandler
    {
        public override void Handle(SupportTicket ticket)
        {
            Console.WriteLine($"[Manager] Taking ownership of CRITICAL issue: '{ticket.Issue}'");
        }
    }
}
