using TemplateMethodPattern.Exporters;


var data = new List<string> { "Alice", "Bob", "Charlie" };

Console.WriteLine("=== CSV Export ===");
new CsvExporter().Export(data);

Console.WriteLine();

Console.WriteLine("=== JSON Export ===");
new JsonExporter().Export(data);
