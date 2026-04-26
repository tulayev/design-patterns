using CommandPattern.Commands;
using CommandPattern.Invokers;
using CommandPattern.Receivers;


var editor = new TextEditor();
var doc = new Document();

editor.ExecuteCommand(new AppendCommand(doc, "Hello"));
editor.ExecuteCommand(new AppendCommand(doc, ", World"));
editor.ExecuteCommand(new AppendCommand(doc, "!"));

Console.WriteLine("\r\n-- Undo --\r\n");

editor.Undo();
editor.Undo();
