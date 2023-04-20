using SOLID.OpenClosed.Interfaces;

namespace SOLID.OpenClosed.Classes
{
    public class CountrySpecification : ISpecification<Movie>
    {
        private readonly string _country;

        public CountrySpecification(string country)
        {
            _country = country;
        }

        public bool IsSatisfied(Movie t) =>
            t.Country.Equals(_country);
    }
}
