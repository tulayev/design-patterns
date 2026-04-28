using MediatorPattern;


var mediator = new Mediator();

var john = new Participant(mediator);
var alice = new Participant(mediator);

Console.WriteLine(john.Value);
Console.WriteLine(alice.Value);

john.Say(10);
alice.Say(5);

Console.WriteLine(john.Value);
Console.WriteLine(alice.Value);
