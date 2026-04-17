using AdapterPattern;

Console.WriteLine("Getting the interface you want from the interface you have. The Adapter is a structural design pattern that allows objects with incompatible interfaces to collaborate. " +
    "It acts as a wrapper that translates the calls from a client into a format that a service (adaptee) can understand.\r\n" +
    "Key Components:\r\n" +
    "Target Interface: The specific interface that the client code expects and uses.\r\n" +
    "Client: The class containing the existing business logic that needs to interact with a service.\r\n" +
    "Adaptee: An existing class (often 3rd-party or legacy) with a useful function but an incompatible interface.\r\n" +
    "Adapter: The \"middle-man\" class that implements the Target Interface and translates calls to the Adaptee.\r\n");

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
