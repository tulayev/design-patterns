namespace OOP.Inheritance
{
    internal class Contractor : Employee
    {
        private readonly int _hoursWorked;

        public Contractor(string name, decimal hourlyRate, int hours) : base(name, hourlyRate)
        {
            _hoursWorked = hours;
        }

        public override decimal GetSalary()
        {
            return Base * _hoursWorked;
        }
    }
}
