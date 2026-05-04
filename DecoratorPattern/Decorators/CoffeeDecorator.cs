internal abstract class CoffeeDecorator : ICoffee
{
    protected readonly ICoffee Coffee;
    
    protected CoffeeDecorator(ICoffee coffee)
    {
        Coffee = coffee;
    }

    public virtual string GetDescription()
    {
        return Coffee.GetDescription();
    }

    public virtual decimal GetCost()
    {
        return Coffee.GetCost();
    }

    public override string ToString()
    {
        return $"{GetDescription()} - {GetCost()} UZS";
    }
}
