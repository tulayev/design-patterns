using MementoPattern;


var editor = new TextEditor();
var history = new History();

editor.Type("Hello");
history.Push(editor.Save());

editor.Type(", World");
history.Push(editor.Save());

editor.Type("!!!");

Console.WriteLine("\n-- Undo --");
editor.Restore(history.Pop()!);
Console.WriteLine($"[Editor] '{editor.GetContent()}'");

Console.WriteLine("\n-- Undo --");
editor.Restore(history.Pop()!);
Console.WriteLine($"[Editor] '{editor.GetContent()}'");
