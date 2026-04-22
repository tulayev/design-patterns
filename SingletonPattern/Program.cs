using SingletonPattern;

/*
The Singleton Design Pattern is a creational design pattern that ensures a class has only one instance while providing a global point of access to that instance. 
It is one of the most widely used—and debated—patterns in software engineering. 

1. Core Principles. A class must meet three criteria to be considered a Singleton: 
    Private Constructor: Prevents other classes from instantiating the class using the new operator.
    Static Instance Variable: A private static variable that holds the single instance of the class.
    Public Static Method: Often called getInstance(), this serves as the global access point. It returns the existing instance or creates a new one if it doesn't exist yet. 

2. Implementation Strategies:
    There are several ways to implement the pattern, each with different trade-offs regarding memory and performance.

Why is it often called an Anti-Pattern?
The "anti-pattern" label comes from the side effects that arise when Singletons are overused or used as a convenient shortcut for global variables. 

A. Violation of SOLID Principles:
    Single Responsibility Principle (SRP): A Singleton is responsible for both its actual business logic and managing its own lifecycle (ensuring only one instance exists). This dual responsibility makes the class harder to maintain.
    Dependency Inversion Principle (DIP): Instead of depending on abstractions, classes that use a Singleton depend on a concrete class. You cannot easily swap the Singleton for a different implementation without modifying all the calling code. 

B. Testing Nightmares (Unit Testing). Singletons are the "enemy" of unit testing for several reasons: 
    Persistent State: Because a Singleton lives for the life of the application, state carries over between tests. If Test A changes a value in the Singleton, Test B may fail because it expects the initial state. This makes tests dependent on their execution order.
    Hidden Dependencies: When a class uses MySingleton.getInstance(), the dependency isn't visible in the class constructor. You might try to test a "simple" class only to find it triggers a complex database or network Singleton in the background.
    Mocking Difficulty: Since the constructor is private and the instance is accessed through a static method, it is extremely difficult to replace a Singleton with a "mock" or "fake" version during testing. 

C. It's a "Global Variable in Disguise":
    Global state is generally considered bad practice because it makes the flow of data hard to track. Any part of the code can change a Singleton's state at any time, leading to bugs that are difficult to debug or reproduce. 

D. Multi-threading and Scalability Issues 
    Race Conditions: Implementing a thread-safe Singleton requires complex locking (like "double-checked locking"), which is easy to get wrong and can cause performance bottlenecks.
    Cluster/Distributed Problems: A Singleton is only "single" within one process or JVM. In modern cloud environments where applications run across multiple servers, the "singleton" assumption breaks down entirely, as each instance has its own version. 

E. Hard to Refactor
    The assumption that you will "only ever need one" of something is often proven wrong as an application grows. 
    Refactoring a codebase away from a Singleton that is used in hundreds of places is a massive, error-prone task. 
*/


var data = FileReader.Instance;
var city = "Tashkent";

Console.WriteLine($"{city} has {data.GetPopulation(city)} population.");
