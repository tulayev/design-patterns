namespace OOP.Inheritance
{
    internal class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, decimal salary) : base(name, salary) 
        {
        }

        public override decimal GetSalary()
        {
            return Base;
        }
    }
}
