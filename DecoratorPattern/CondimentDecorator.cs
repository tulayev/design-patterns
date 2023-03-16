namespace DecoratorPattern
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage Beverage;

        public override string Description =>
            Beverage != null ? Beverage.Description : string.Empty;
    }
}
