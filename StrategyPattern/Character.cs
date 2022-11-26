using StrategyPattern.Weapons;

namespace StrategyPattern
{
    public abstract class Character
    {
        private IWeaponBehavior _weaponBehavior; 

        public void Fight() =>
            _weaponBehavior.UseWeapon();

        public void SetWeaponBehavior(IWeaponBehavior weaponBehavior) => 
            _weaponBehavior = weaponBehavior;
    }
}