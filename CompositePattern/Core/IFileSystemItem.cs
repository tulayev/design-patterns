namespace CompositePattern.Core
{
    internal interface IFileSystemItem
    {
        string Name { get; }
        long GetSize();
    }
}
