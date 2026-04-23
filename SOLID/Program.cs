using SOLID.LiskovSubstitution;
using SOLID.OpenClosed;
using SOLID.OpenClosed.Classes;
using SOLID.SingleResponsibility;


Console.WriteLine("Single responsibility. A class should have only one responsibility. ");

var persistence = new Persistence();
var journal = new Journal();

journal.AddEntry("Hello");
journal.AddEntry("there!");
persistence.SaveToFile(journal, "journal.txt");


Console.WriteLine("Open Closed. Classes should be extendible, but not modifiable.");

var hobbit = new Movie 
{ 
    Title = "Hobbit", 
    Genre = Genre.Fantasy, 
    Country = "USA" 
};
var interstellar = new Movie 
{ 
    Title = "Interstellar", 
    Genre = Genre.SciFi, 
    Country = "USA" 
};

var movies = new List<Movie> { hobbit, interstellar };

var filter = new CustomFilter();
var filteredMovies = filter.Filter(movies, 
    new AndSpecification<Movie>(
        new GenreSpecification(Genre.Fantasy),
        new CountrySpecification("USA")
    )
);

foreach (var movie in filteredMovies)
{
    Console.WriteLine(movie);
}


Console.WriteLine("Liskov substitution. A class that expects an object of type Rectangle should work as if a subclass Square is passed.");

Rectangle rectangle = new()
{
    Width = 12,
    Height = 14
};

Rectangle square = new Square
{
    Width = 12
};

Console.WriteLine(rectangle.Area());
Console.WriteLine(square.Area());
