namespace FlyweightPattern
{
    // Client
    internal class Forest
    {
        private readonly List<Tree> _trees = [];

        public void PlantTree(int x, int y, string name, string color, string texture)
        {
            var type = TreeFactory.GetTreeType(name, color, texture);
            var tree = new Tree(x, y, type);
            _trees.Add(tree);
        }

        public void Draw()
        {
            foreach (var tree in _trees)
            {
                tree.Draw();
            }
        }
    }
}
