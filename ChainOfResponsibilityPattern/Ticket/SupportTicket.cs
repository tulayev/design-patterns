namespace ChainOfResponsibilityPattern.Ticket
{
    internal class SupportTicket
    {
        public string Issue { get; set; } = default!;
        public TicketPriority Priority { get; set; }
    }
}
