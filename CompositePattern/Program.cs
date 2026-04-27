using CompositePattern;
using CompositePattern.Composite;


// Files
var resume = new CompositePattern.Leaf.File("resume.pdf", 120);
var photo = new CompositePattern.Leaf.File("photo.jpg", 340);
var notes = new CompositePattern.Leaf.File("notes.txt", 18);
var app = new CompositePattern.Leaf.File("app.exe", 2048);
var config = new CompositePattern.Leaf.File("config.json", 12);
var readme = new CompositePattern.Leaf.File("README.md", 8);

// Tree structure
var documents = new Folder("Documents");
documents.Add(resume);
documents.Add(notes);

var pictures = new Folder("Pictures");
pictures.Add(photo);

var project = new Folder("Project");
project.Add(app);
project.Add(config);
project.Add(readme);

var root = new Folder("C:");
root.Add(documents);
root.Add(pictures);
root.Add(project);

/*
C:/
├── 📁 Documents/
│   ├── 📄 resume.pdf
│   └── 📄 notes.txt
├── 📁 Pictures/
│   └── 📄 photo.jpg
└── 📁 Project/
    ├── 📄 app.exe
    ├── 📄 config.json
    └── 📄 README.md 
*/
FileSystemPrinter.Display(root);

Console.WriteLine();
Console.WriteLine($"Documents: {documents.GetSize()} KB");
Console.WriteLine($"Project: {project.GetSize()} KB");
Console.WriteLine($"Total: {root.GetSize()} KB");
