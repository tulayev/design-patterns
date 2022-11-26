namespace StrategyPattern.Weapons
{
    public class SwordBehavior : IWeaponBehavior
    {
        public void UseWeapon() =>
            Console.WriteLine("This sword is a legendary Excalibur. It's so sharp!");
    }
}