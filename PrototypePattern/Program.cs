using PrototypePattern;

/*
The Prototype Design Pattern is a creational pattern that creates new objects by cloning an existing instance (a prototype) rather than creating them from scratch. 
It is used to avoid expensive initialization costs, such as complex database queries or intensive calculations, when creating similar objects. 
This approach increases performance and flexibility, allowing for rapid instantiation of complex object configurations. 

1. Key Components & Concepts:
    Prototype Interface: Defines a method, typically clone(), for cloning itself.
    Concrete Prototype: Implements the cloning method to create a copy of itself.
    Client: Creates new objects by asking the prototype to clone itself, reducing dependency on concrete classes. 

2. When to Use:
    When object initialization is costly or complex.
    To avoid deep hierarchies of creator classes.
    When you need to create copies of an object with many different configurations.
    When you want to reduce the dependency of client code on concrete subclasses. 

3. Benefits:
    Performance Optimization: Reduces the need for expensive initialization (e.g., loading large datasets).
    Reduced Complexity: Simplifies the creation of complex objects by cloning pre-built prototypes.
    Loose Coupling: Clients can create new objects without knowing their specific concrete classes. 

4. Common Examples:
    Game Engines: Cloning complex character or enemy objects during gameplay.
    Document Management: Using a base document template as a prototype to create new documents, avoiding re-designing layouts.
    Configuration Management: Creating varied configurations based on a default base configuration. 

This pattern is often compared to the Factory Method but is generally used when the creation process is too complex or costly to re-run
*/


var jon = new Person(
    new string[] { "Jon", "Snow" }, 
    new Address("Winterfell", "Some street")
);

// Avoid shallow copying when we copy only the reference, so one change in one object affects another.
var copy = jon.DeepCopyXml();
copy.Names = new string[] { "Arya", "Stark" };

Console.WriteLine(jon);
Console.WriteLine(copy);
