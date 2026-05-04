internal class WhipDecorator : CoffeeDecorator
{
    public WhipDecorator(ICoffee coffee) : base(coffee) 
    {
    }

    public override string GetDescription()
    {
        return Coffee.GetDescription() + ", Whip";
    }

    public override decimal GetCost()
    {
        return Coffee.GetCost() + 15_000m;
    }
}
