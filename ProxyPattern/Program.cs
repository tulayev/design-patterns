using ProxyPattern.Services;


var service = new PaymentServiceProxy(new PaymentService());

Console.WriteLine("=== Authorized User ===");
service.GetBalance("user1");
service.ProcessPayment("user1", 200m);

Console.WriteLine("\n=== Unauthorized User ===");
service.ProcessPayment("user2", 100m);
