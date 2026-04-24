namespace ChainOfResponsibilityPattern.Ticket.Handlers
{
    internal class SeniorSupportHandler : SupportHandler
    {
        public override void Handle(SupportTicket ticket)
        {
            if (ticket.Priority <= TicketPriority.High)
            {
                Console.WriteLine($"[Senior Support] Resolved: '{ticket.Issue}'");
            }
            else
            {
                Console.WriteLine($"[Senior Support] Escalating to management...");
                _next?.Handle(ticket);
            }
        }
    }
}
