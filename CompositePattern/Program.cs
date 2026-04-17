using CompositePattern;

Console.WriteLine("The Composite Design Pattern is a structural design pattern that lets you compose objects into tree structures to represent part-whole hierarchies. " +
    "It allows clients to treat individual objects and compositions of objects uniformly through a common interface.\r\n" +
    "Key concepts:\r\n" +
    "Uniformity: The client does not need to know whether it is dealing with a single leaf or a complex branch; it interacts with both using the same methods.\r\n" +
    "Tree Structure: Objects are organized in a hierarchy where \"containers\" can hold \"leaves\" or other \"containers.\"\r\n");

var drawing = new GraphicObject { Name = "My drawing" };
drawing.Children.Add(new Square { Color = "Red" });
drawing.Children.Add(new Circle { Color = "Yellow" });

var group = new GraphicObject();
group.Children.Add(new Square { Color = "Blue" });
group.Children.Add(new Circle { Color = "Blue" });

drawing.Children.Add(group);

Console.WriteLine(drawing);
