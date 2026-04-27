using CompositePattern.Core;

namespace CompositePattern.Leaf
{
    internal class File : IFileSystemItem
    {
        public string Name { get; }
        private readonly long _size;

        public File(string name, long sizeKb)
        {
            Name = name;
            _size = sizeKb;
        }

        public long GetSize()
        {
            return _size;
        }
    }
}
