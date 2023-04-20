using SOLID.OpenClosed;
using SOLID.OpenClosed.Classes;

var hobbit = new Movie { Title = "Hobbit", Genre = Genre.Fantasy, Country = "USA" };
var interstellar = new Movie { Title = "Interstellar", Genre = Genre.SciFi, Country = "USA" };
var movies = new List<Movie> { hobbit, interstellar };

var filter = new CustomFilter();
var filteredMovies = filter.Filter(movies, new AndSpecification<Movie>(
        new GenreSpecification(Genre.Fantasy),
        new CountrySpecification("USA")
    ));

foreach (var movie in filteredMovies)
    Console.WriteLine(movie);
