using BuilderPattern;

Console.WriteLine("The Builder Design Pattern is a creational pattern used to construct complex objects step by step. " +
    "It separates the construction logic of an object from its final representation, allowing the same construction process to create different types and configurations.\r\n" +
    "Core Components:\r\n" +
    "Product: The complex object being built.\r\n" +
    "Builder Interface: An abstract interface or class defining the steps to create the product.\r\n" +
    "Concrete Builder: Implements the construction steps and maintains the current state of the product.\r\n" +
    "Director (Optional): A class that defines the order in which to execute the building steps.\r\n" +
    "Client: Initiates the construction by providing a builder to the director or by chaining steps directly.\r\n");

var builder = new HtmlBuilder("ul");
builder.AddChild("li", "First")
    .AddChild("li", "Second");
Console.WriteLine(builder.ToString());
