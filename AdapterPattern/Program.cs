using AdapterPattern.Adapter;
using AdapterPattern.Logger;
using AdapterPattern.Services;


ILogger logger = new SerilogAdapter();

var orderService = new OrderService(logger);

orderService.PlaceOrder("Laptop", 3);
Console.WriteLine();
orderService.PlaceOrder("USB Cable", 150);
Console.WriteLine();
orderService.PlaceOrder("Monitor", -1);
