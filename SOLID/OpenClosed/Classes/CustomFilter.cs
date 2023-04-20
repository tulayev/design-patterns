using SOLID.OpenClosed.Interfaces;

namespace SOLID.OpenClosed.Classes
{
    public class CustomFilter : IFilter<Movie>
    {
        public IEnumerable<Movie> Filter(IEnumerable<Movie> items, ISpecification<Movie> spec)
        {
            foreach (var item in items) 
                if (spec.IsSatisfied(item))
                    yield return item;
        }
    }
}
