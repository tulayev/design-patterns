namespace ChainOfResponsibilityPattern.Ticket.Handlers
{
    internal abstract class SupportHandler
    {
        protected SupportHandler? _next;

        public SupportHandler SetNext(SupportHandler next)
        {
            _next = next;
            return next; // enables fluent chaining
        }

        public abstract void Handle(SupportTicket ticket);
    }
}
