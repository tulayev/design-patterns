namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public abstract string Description { get; }
        
        public abstract decimal Cost();

        public override string ToString() =>
            $"{Description} -> ${Cost()}";
    }
}
