namespace OOP.Inheritance
{
    internal abstract class Employee
    {
        public string Name { get; }
        public decimal Base { get; }

        protected Employee(string name, decimal baseSalary)
        {
            (Name, Base) = (name, baseSalary);
        }

        public abstract decimal GetSalary();

        public void PrintSalary()
        {
            Console.WriteLine($"{Name}: {GetSalary():F2}");
        }
    }
}
