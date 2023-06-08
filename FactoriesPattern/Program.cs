using FactoriesPattern.AbstractFactory;

var machine = new HotDrinkMachine();
var drink = machine.MakeDrink();
drink.Consume();
