using CompositePattern.Core;

namespace CompositePattern.Composite
{
    internal class Folder : IFileSystemItem
    {
        public string Name { get; }
        public List<IFileSystemItem> Children { get; } = [];

        public Folder(string name)
        {
            Name = name;
        }

        public void Add(IFileSystemItem item)
        {
            Children.Add(item);
        }

        public void Remove(IFileSystemItem item)
        {
            Children.Remove(item);
        }

        public long GetSize()
        {
            return Children.Sum(c => c.GetSize());
        }
    }
}
