using SOLID.OpenClosed.Interfaces;

namespace SOLID.OpenClosed.Classes
{
    public class GenreSpecification : ISpecification<Movie>
    {
        private readonly Genre _genre;

        public GenreSpecification(Genre genre)
        {
            _genre = genre;
        }

        public bool IsSatisfied(Movie t) =>
            t.Genre == _genre;
    }
}
