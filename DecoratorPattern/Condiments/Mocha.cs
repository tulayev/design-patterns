namespace DecoratorPattern.Condiments
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            Beverage = beverage;     
        }

        public override string Description =>
            $"{Beverage.Description}, Mocha";

        public override decimal Cost()
        {
            return Beverage.Cost() + 0.20M;
        }
    }
}
