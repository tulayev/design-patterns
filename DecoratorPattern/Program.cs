using DecoratorPattern;
using DecoratorPattern.Coffees;
using DecoratorPattern.Condiments;

Console.WriteLine("The Decorator is a structural design pattern used to add behaviors to individual objects, dynamically or statically, without impacting others of the same class. " +
    "By employing a \"wrapper\" mechanism, this pattern allows for stacking functionality through composition rather than inheritance, offering a flexible alternative to subclassing.\r\n" +
    "Key Characteristics:\r\n" +
    "Wrapper Mechanism: Decorators contain the original object and follow the same interface, making the decoration process transparent to the client.\r\n" +
    "Composition Over Inheritance: Features are added by wrapping the core object in multiple layers, rather than creating subclasses for every combination.\r\n" +
    "Recursive Chaining: Because decorators share the same interface as the objects they wrap, they can be stacked in unlimited chains. \r\n" +
    "Core Components:\r\n" +
    "Component (Interface): Defines the common interface for objects and decorators.\r\n" +
    "Concrete Component: The basic, core object.\r\n" +
    "Base Decorator: An abstract class that implements the interface and maintains a reference to a Component object.\r\n" +
    "Concrete Decorators: Specific wrappers that extend the functionality\r\n");

Beverage beverage = new HouseBlend();
beverage = new Mocha(beverage);

Console.WriteLine(beverage.ToString());
