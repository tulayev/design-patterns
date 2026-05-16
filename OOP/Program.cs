using OOP.Abstraction;
using OOP.Encapsulation;
using OOP.Inheritance;
using OOP.Polymorphism;


Console.WriteLine("Encapsulation");

var account = new BankAccount();
account.Deposit(500);
account.Withdraw(200);
Console.WriteLine(account.GetBalance()); // 300


Console.WriteLine("Abstraction. Client only knows about IPaymentGateway — not Click or Payme internals");
IPaymentGateway gateway = new PaymeGateway();
gateway.Charge("customer_123", 100_000.978m);


Console.WriteLine("Inheritance");
var employees = new List<Employee>
{
    new FullTimeEmployee("Alice", 1_000_000),
    new Contractor("Bob", 2_500_000, 120)
};

employees.ForEach(e => e.PrintSalary());


Console.WriteLine("Polymorphism. Same method call — different behavior depending on the type.");
var notifications = new List<Notification>
{
    new EmailNotification(),
    new SmsNotification(),
    new PushNotification()
};

notifications.ForEach(n => n.Send("Your order has shipped!"));
