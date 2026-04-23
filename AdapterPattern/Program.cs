using AdapterPattern;


var vectorObjects = new List<VectorObject>
{
    new VectorRectangle(1, 1, 10, 10),
    new VectorRectangle(3, 3, 6, 6)
};

void DrawPoint(Point p)
{
    Console.Write(".");
}

void Draw()
{
    foreach (var vo in vectorObjects)
    {
        foreach (var line in vo)
        {
            var adapter = new LineToPointAdapter(line);

            foreach (var point in adapter)
            {
                DrawPoint(point);
            }
        }
    }
}

Draw();
Draw();
