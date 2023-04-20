using SOLID.OpenClosed.Interfaces;

namespace SOLID.OpenClosed.Classes
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _firstSpec, _secondSpec;

        public AndSpecification(ISpecification<T> firstSpec, ISpecification<T> secondSpec)
        {
            _firstSpec = firstSpec ?? throw new ArgumentNullException(paramName: nameof(firstSpec));
            _secondSpec = secondSpec ?? throw new ArgumentNullException(paramName: nameof(secondSpec));
        }

        public bool IsSatisfied(T t) =>
            _firstSpec.IsSatisfied(t) && _secondSpec.IsSatisfied(t);
    }
}
