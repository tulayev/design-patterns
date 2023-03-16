namespace DecoratorPattern.Coffees
{
    public class Espresso : Beverage
    {
        public override string Description => 
            "Espresso";

        public override decimal Cost()
        {
            return 1.99M;
        }
    }
}
