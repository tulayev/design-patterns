using DecoratorPattern;
using DecoratorPattern.Coffees;
using DecoratorPattern.Condiments;

/*
The Decorator Design Pattern is a structural design pattern that allows you to dynamically attach new behaviors and responsibilities to an object without altering its code 
or affecting other instances of the same class. Commonly referred to as a Wrapper, it provides a flexible alternative to subclassing for extending functionality. 

1. Key Concept: Composition over Inheritance
    In traditional inheritance, you extend a class at compile-time to add features. 
    This often leads to a "class explosion" if you need many combinations of features (e.g., BoldItalicUnderlinedText, BoldItalicText, etc.). 
    The Decorator pattern solves this by wrapping the core object in one or more decorator classes. 
    Since the decorators implement the same interface as the object they wrap, they can be stacked indefinitely. 

2. Core Components:
    The pattern typically consists of four main parts: 
    Component (Interface): Defines the common interface for both the core object and the decorators.
    Concrete Component: The original object that provides the basic functionality (e.g., a "Plain Coffee" or "Plain Text").
    Base Decorator: An abstract class that implements the Component interface and holds a reference to a Component object. It delegates all work to the wrapped object.
    Concrete Decorators: Classes that extend the Base Decorator and add specific features (e.g., "MilkDecorator", "BoldDecorator") before or after calling the wrapped object's method. 

3. Real-World Analogy
    Clothing: You are the "Concrete Component." When it's cold, you wrap yourself in a "Sweater Decorator." 
    If it rains, you add a "Raincoat Decorator" on top. Each layer adds a new property (warmth, waterproofing) without changing who you are.
    Coffee Shop: You start with a basic coffee. You can decorate it with milk, sugar, or whipped cream. Each "decorator" adds its own cost and description to the base beverage.  
*/


Beverage beverage = new HouseBlend();
beverage = new Mocha(beverage);

Console.WriteLine(beverage.ToString());
