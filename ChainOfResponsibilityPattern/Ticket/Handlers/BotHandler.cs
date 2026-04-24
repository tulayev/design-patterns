namespace ChainOfResponsibilityPattern.Ticket.Handlers
{
    internal class BotHandler : SupportHandler
    {
        public override void Handle(SupportTicket ticket)
        {
            if (ticket.Priority == TicketPriority.Low)
            {
                Console.WriteLine($"[Bot] Auto-resolved: '{ticket.Issue}'");
            }
            else
            {
                Console.WriteLine($"[Bot] Cannot handle '{ticket.Priority}' — escalating...");
                _next?.Handle(ticket);
            }
        }
    }
}
