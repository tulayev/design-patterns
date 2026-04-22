using AdapterPattern;

/*
Getting the interface you want from the interface you have.The Adapter is a structural design pattern that allows objects with incompatible interfaces to collaborate.

1. Key Components:
    Target(Interface): The domain-specific interface that the client code uses.
    Adapter: A class that implements the Target interface and wraps the Adaptee.
    Adaptee: The existing class with an incompatible interface that needs adapting.
    Client: The code that collaborates with objects adhering to the Target interface.

2. Implementation Approaches:
    Object Adapter (Composition): The adapter contains an instance of the adaptee class. This is the preferred approach, especially in languages like Java.
    Class Adapter (Inheritance): The adapter inherits from the adaptee class and implements the target interface, requiring multiple inheritance (not supported in all languages).
*/


var vectorObjects = new List<VectorObject>
{
    new VectorRectangle(1, 1, 10, 10),
    new VectorRectangle(3, 3, 6, 6)
};

void DrawPoint(Point p)
{
    Console.Write(".");
}

void Draw()
{
    foreach (var vo in vectorObjects)
    {
        foreach (var line in vo)
        {
            var adapter = new LineToPointAdapter(line);

            foreach (var point in adapter)
            {
                DrawPoint(point);
            }
        }
    }
}

Draw();
Draw();
