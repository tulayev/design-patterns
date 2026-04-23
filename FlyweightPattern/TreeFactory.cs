namespace FlyweightPattern
{
    // Flyweight Factory (caches shared objects)
    internal static class TreeFactory
    {
        private static readonly Dictionary<string, TreeType> _treeTypes = [];

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            var key = $"{name}_{color}_{texture}";

            if (!_treeTypes.ContainsKey(key))
            {
                _treeTypes[key] = new TreeType(name, color, texture);
            }

            return _treeTypes[key];
        }
    }
}
