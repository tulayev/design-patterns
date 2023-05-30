namespace SOLID.InterfaceSegregation
{
    public interface IScaner
    {
        void Scan();
    }
    
    public interface IPrinter
    {
        void Print();
    }

    public class Printer : IPrinter
    {
        public void Print()
        {
            throw new NotImplementedException();
        }
    }

    public class Scaner : IScaner
    {
        public void Scan()
        {
            throw new NotImplementedException();
        }
    }
}
