Console.WriteLine("=== With Real Logger ===");
var withLogger = new OrderService(new ConsoleLogger());
withLogger.PlaceOrder("Laptop", 2);

Console.WriteLine("\r\n=== Without Logger (silent) ===");
var withoutLogger = new OrderService(); // uses NullLogger internally
withoutLogger.PlaceOrder("Laptop", 2); // no output, no crashes
