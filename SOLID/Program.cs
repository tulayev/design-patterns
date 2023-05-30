using SOLID.LiskovSubstitution;
using SOLID.OpenClosed;
using SOLID.OpenClosed.Classes;
using SOLID.SingleResponsibility;

/*
Single responsibility. A class should have only one responsibility. 
That means that for example, a Person class should only worry about the domain problem regarding the person itself, and not for example, its persistence in the database. 
For that, you may want to use a PersonDAO for example. A Person class may want to keep its responsibilities the shortest it can. 
If a class is using too many external dependencies (that is, other classes), that's a symptom that the class is having too many responsibilities. 
This problem often comes when developers try to model the real world using objects and take it too far. 
Loosely coupled applications often are not very easy to navigate and do not exactly model how the real world works.
*/
var persistence = new Persistence();
var journal = new Journal();
journal.AddEntry("Hello");
journal.AddEntry("there!");
persistence.SaveToFile(journal, "journal.txt");

/*
Open Closed. Classes should be extendible, but not modifiable. That means that adding a new field to a class is fine, but changing existing things are not. 
Other components on the program may depend on said field. 
*/
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

/*
Liskov substitution. A class that expects an object of type Rectangle should work if a subclass Square is passed.
*/
Rectangle rectangle = new()
{
    Width = 12,
    Height = 14
};

Rectangle square = new Square
{
    Width = 12
};

/*
Interface segregation principle. Keep your interfaces the smallest you can. 
A teacher that also is a student should implement both the IStudent and ITeacher interfaces, instead of a single big interface called IStudentAndTeacher.
*/

/*
Dependency inversion principle. Objects should not instantiate their dependencies, but they should be passed to them. 
For example, a Car that has an Engine object inside should not do engine = new DieselEngine(), but rather said engine should be passed to it on the constructor. 
This way the car class will not be coupled to the DieselEngine class. 
*/
