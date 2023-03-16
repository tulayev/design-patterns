using DecoratorPattern;
using DecoratorPattern.Coffees;
using DecoratorPattern.Condiments;

Beverage beverage = new HouseBlend();
beverage = new Mocha(beverage);
Console.WriteLine(beverage.ToString());
