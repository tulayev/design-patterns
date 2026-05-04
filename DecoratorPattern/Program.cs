// Plain coffee
ICoffee coffee = new SimpleCoffee();
Console.WriteLine(coffee);

// Coffee + Milk
coffee = new MilkDecorator(coffee);
Console.WriteLine(coffee);

// Coffee + Milk + Sugar
coffee = new SugarDecorator(coffee);
Console.WriteLine(coffee);

// Coffee + Milk + Sugar + Caramel + Whip
coffee = new CaramelDecorator(coffee);
coffee = new WhipDecorator(coffee);
Console.WriteLine(coffee);
