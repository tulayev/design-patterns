internal class SimpleCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Coffee";
    }

    public decimal GetCost()
    {
        return 25_000m;
    }

    public override string ToString()
    {
        return $"{GetDescription()} - {GetCost()} UZS";
    }
}
