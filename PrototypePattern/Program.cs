using PrototypePattern;


var jon = new Person(
    new string[] { "Jon", "Snow" }, 
    new Address("Winterfell", "Some street")
);

// Avoid shallow copying when we copy only the reference, so one change in one object affects another.
var copy = jon.DeepCopyXml();
copy.Names = new string[] { "Arya", "Stark" };

Console.WriteLine(jon);
Console.WriteLine(copy);
