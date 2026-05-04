internal class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) 
    {
    }

    public override string GetDescription()
    {
        return Coffee.GetDescription() + ", Sugar";
    }

    public override decimal GetCost()
    {
        return Coffee.GetCost() + 2_000m;
    }
}
