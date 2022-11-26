namespace StrategyPattern.Weapons
{
    public class AxeBehavior : IWeaponBehavior
    {
        public void UseWeapon() =>
            Console.WriteLine("The only weapon I can use is axe");
    }
}