using BuilderPattern;

/*
The Builder Design Pattern is a creational design pattern that allows you to construct complex objects step by step. 
It separates the construction logic of an object from its final representation, enabling the same construction process to create different types and variations of an object. 

1. The Core Problem
In software development, you often encounter the "Telescoping Constructor" anti-pattern. This happens when a class has many optional fields, 
leading to multiple constructors with increasing numbers of parameters: 
Problem: Hard to read and maintain
    User(String name) { ... }
    User(String name, int age) { ... }
    User(String name, int age, String email) { ... }
    User(String name, int age, String email, String address) { ... }
Using the Builder pattern avoids this mess by allowing you to set only the parameters you need, in any order, while keeping the final object immutable. 

2. Key Components:
    Product: The complex object that is being built (e.g., a House or an HTTP Request).
    Builder Interface: Defines the steps required to build the product.
    Concrete Builder: Implements the building steps and keeps track of the object's current state.
    Director (Optional): A separate class that defines the order in which to execute the building steps. This is useful for pre-defined "recipes" (e.g., a Director that builds a "Standard Laptop" vs. a "Gaming Laptop").
    Client: The code that initiates the building process.  
*/


var builder = new HtmlBuilder("ul");
builder.AddChild("li", "First")
    .AddChild("li", "Second");
Console.WriteLine(builder.ToString());
