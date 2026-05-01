var tokenMachine = new TokenMachine();

var snapShot1 = tokenMachine.AddToken(1);
var snapShot2 = tokenMachine.AddToken(2);
var snapShot3 = tokenMachine.AddToken(3);

Console.WriteLine(tokenMachine);

tokenMachine.Revert(snapShot1);

Console.WriteLine(tokenMachine);
