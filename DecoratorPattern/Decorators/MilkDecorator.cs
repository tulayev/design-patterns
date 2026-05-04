internal class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) 
    {
    }

    public override string GetDescription()
    {
        return Coffee.GetDescription() + ", Milk";
    }

    public override decimal GetCost()
    {
        return Coffee.GetCost() + 10_000m;
    }
}
