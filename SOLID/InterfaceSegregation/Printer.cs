namespace SOLID.InterfaceSegregation
{
    internal interface IScaner
    {
        void Scan();
    }

    internal interface IPrinter
    {
        void Print();
    }

    internal class Printer : IPrinter
    {
        public void Print()
        {
            throw new NotImplementedException();
        }
    }

    internal class Scaner : IScaner
    {
        public void Scan()
        {
            throw new NotImplementedException();
        }
    }
}
