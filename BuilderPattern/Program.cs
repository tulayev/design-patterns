using BuilderPattern;

var builder = new HtmlBuilder("ul");
builder.AddChild("li", "First")
    .AddChild("li", "Second");
Console.WriteLine(builder.ToString());
