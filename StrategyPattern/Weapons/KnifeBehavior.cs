namespace StrategyPattern.Weapons
{
    public class KnifeBehavior : IWeaponBehavior
    {
        public void UseWeapon() =>
            Console.WriteLine("I can stab you, because I have a knife");
    }
}