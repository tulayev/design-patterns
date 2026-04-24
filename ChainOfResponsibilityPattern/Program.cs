// Build the chain
using ChainOfResponsibilityPattern.Ticket;
using ChainOfResponsibilityPattern.Ticket.Handlers;


var bot = new BotHandler();
var junior = new JuniorSupportHandler();
var senior = new SeniorSupportHandler();
var manager = new ManagerHandler();

bot.SetNext(junior)
   .SetNext(senior)
   .SetNext(manager);

// Test tickets
var tickets = new[]
{
    new SupportTicket { Issue = "How do I reset my password?", Priority = TicketPriority.Low      },
    new SupportTicket { Issue = "Order not delivered",         Priority = TicketPriority.Medium   },
    new SupportTicket { Issue = "Payment processing error",    Priority = TicketPriority.High     },
    new SupportTicket { Issue = "Data breach detected!",       Priority = TicketPriority.Critical },
};

foreach (var ticket in tickets)
{
    Console.WriteLine($"\r\n--- Ticket: [{ticket.Priority}] {ticket.Issue} ---");
    bot.Handle(ticket);
}
