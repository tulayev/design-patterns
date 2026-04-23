using FlyweightPattern;


var forest = new Forest();

// Thousands of trees, but only a few TreeType objects
forest.PlantTree(1, 2, "Oak", "Green", "Rough");
forest.PlantTree(3, 4, "Oak", "Green", "Rough");
forest.PlantTree(5, 6, "Pine", "Dark Green", "Smooth");

forest.Draw();
