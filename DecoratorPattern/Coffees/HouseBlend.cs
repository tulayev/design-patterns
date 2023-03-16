namespace DecoratorPattern.Coffees
{
    public class HouseBlend : Beverage
    {
        public override string Description =>
            "House Blend coffee";

        public override decimal Cost()
        {
            return 0.90M;
        }
    }
}
