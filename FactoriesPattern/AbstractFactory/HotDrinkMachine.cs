namespace FactoriesPattern.AbstractFactory
{
    public interface IHotDrink
    {
        void Consume();
    }

    internal class Tea : IHotDrink
    {
        public void Consume() =>
            Console.WriteLine("Nice tea!");
    }
    
    internal class Coffee : IHotDrink
    {
        public void Consume() =>
            Console.WriteLine("Nice coffee!");
    }

    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }

    internal class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Put a tea bag, boil water, pour {amount} ml, add lemon.");
            return new Tea();
        }
    }
    
    internal class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Grind some beans, boil water, pour {amount} ml, add cream and sugar.");
            return new Coffee();
        }
    } 

    public class HotDrinkMachine
    {
        private readonly List<Tuple<string, IHotDrinkFactory>> _factories = new();

        // Reflection
        public HotDrinkMachine()
        {
            foreach (var t in typeof(HotDrinkMachine).Assembly.GetTypes())
            {
                if (typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
                    _factories.Add(Tuple.Create(
                        t.Name.Replace("Factory", string.Empty), 
                        (IHotDrinkFactory)Activator.CreateInstance(t))
                    );
            }
        }

        public IHotDrink MakeDrink()
        {
            Console.WriteLine("Available drinks:");
            
            for (int i = 0; i < _factories.Count; i++)
            {
                var tuple = _factories[i];
                Console.WriteLine($"{i}: {tuple.Item1}");
            }

            while (true)
            {
                string s;

                if ((s = Console.ReadLine()) != null && int.TryParse(s, out int i) && i >= 0 && i < _factories.Count)
                {
                    Console.Write("Specify amount: ");
                    s = Console.ReadLine(); 
                    if (s != null && int.TryParse(s, out int amount) && amount > 0)
                        return _factories[i].Item2.Prepare(amount);
                }

                Console.WriteLine("Incorrect input, try again!");
            }
        }
    }
}
