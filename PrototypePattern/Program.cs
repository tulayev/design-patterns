using PrototypePattern;

/*
The Prototype pattern is a creation pattern based on cloning a pre-configured object. 
The idea is that you pick an object that is configured for either the default or in the ballpark of some specific use case and then you clone this object and configure to your exact needs.
For example, say your program uses objects that are created from data parsed from mostley unchanging information retrieved over the network. 
Rather than retrieving the data and re-parsing it each time a new object is created, 
the prototype pattern can be used to simply duplicate the original object whenever a new one is needed.
*/
var jon = new Person(
    new string[] { "Jon", "Snow" }, 
    new Address("Winterfell", "Some street")
);

// Avoid shallow copying when we copy only the reference, so one change in one object affects another.
var copy = jon.DeepCopyXml();
copy.Names = new string[] { "Lol", "Lolov" };

Console.WriteLine(jon);
Console.WriteLine(copy);