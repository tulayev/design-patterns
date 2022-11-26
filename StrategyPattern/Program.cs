using StrategyPattern;
using StrategyPattern.Weapons;

Character valkyrae = new Valkyrae();
valkyrae.SetWeaponBehavior(new AxeBehavior());
valkyrae.Fight();

Character gopnik = new Gopnik();
gopnik.SetWeaponBehavior(new KnifeBehavior());
gopnik.Fight();

Character knight = new Knight();
knight.SetWeaponBehavior(new SwordBehavior());
knight.Fight();