namespace SOLID.OpenClosed.Interfaces
{
    public interface IFilter<T> where T : class
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}
