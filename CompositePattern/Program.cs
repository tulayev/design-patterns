using CompositePattern;


var drawing = new GraphicObject { Name = "My drawing" };
drawing.Children.Add(new Square { Color = "Red" });
drawing.Children.Add(new Circle { Color = "Yellow" });

var group = new GraphicObject();
group.Children.Add(new Square { Color = "Blue" });
group.Children.Add(new Circle { Color = "Blue" });

drawing.Children.Add(group);

Console.WriteLine(drawing);
