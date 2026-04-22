using CompositePattern;

/*
The Composite Design Pattern is a structural pattern used to group objects into tree structures to represent "part-whole" hierarchies. 
Its primary goal is to allow clients to treat individual objects (leaves) and compositions of objects (containers) uniformly. 

1. Core Concept:
    Imagine a file system. A File is a single unit, while a Folder is a container that can hold Files and other Folders. 
    If you want to calculate the total size, you shouldn't have to write different code for a File versus a Folder. 
    Instead, you call getSize() on both, and the Folder recursively calculates the size of its contents. 

2. Key Components:
    Component (Interface/Abstract Class): Declares the common interface for both simple and complex objects (e.g., execute(), display(), or getPrice()).
    Leaf: Represents the basic, indivisible elements of the tree (e.g., a File). It implements the Component methods to perform actual work.
    Composite (Container): Represents complex elements that contain children (Leaves or other Composites). It implements the Component methods by delegating the work to its children, usually through a loop.
    Client: Interacts with all elements through the Component interface, meaning it doesn't need to check whether an object is a single item or a collection.  
*/


var drawing = new GraphicObject { Name = "My drawing" };
drawing.Children.Add(new Square { Color = "Red" });
drawing.Children.Add(new Circle { Color = "Yellow" });

var group = new GraphicObject();
group.Children.Add(new Square { Color = "Blue" });
group.Children.Add(new Circle { Color = "Blue" });

drawing.Children.Add(group);

Console.WriteLine(drawing);
