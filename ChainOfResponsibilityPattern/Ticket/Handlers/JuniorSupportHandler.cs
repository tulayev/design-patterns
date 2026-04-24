namespace ChainOfResponsibilityPattern.Ticket.Handlers
{
    internal class JuniorSupportHandler : SupportHandler
    {
        public override void Handle(SupportTicket ticket)
        {
            if (ticket.Priority <= TicketPriority.Medium)
            {
                Console.WriteLine($"[Junior Support] Resolved: '{ticket.Issue}'");
            }
            else
            {
                Console.WriteLine($"[Junior Support] Out of scope — escalating...");
                _next?.Handle(ticket);
            }
        }
    }
}
