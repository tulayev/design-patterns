internal class CaramelDecorator : CoffeeDecorator
{
    public CaramelDecorator(ICoffee coffee) : base(coffee) 
    {
    }

    public override string GetDescription()
    {
        return Coffee.GetDescription() + ", Caramel";
    }

    public override decimal GetCost()
    {
        return Coffee.GetCost() + 5_000m;
    }
}
