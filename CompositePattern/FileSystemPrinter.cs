using CompositePattern.Composite;
using CompositePattern.Core;

namespace CompositePattern
{
    internal static class FileSystemPrinter
    {
        public static void Display(IFileSystemItem item, string prefix = "", bool isLast = true)
        {
            var connector = isLast ? "└── " : "├── ";
            var label = item is Folder ? "[DIR] " : "[FILE]";
            Console.WriteLine($"{prefix}{connector}{label} {item.Name} ({item.GetSize()} KB)");

            if (item is Folder folder)
            {
                var newPrefix = prefix + (isLast ? "    " : "│   ");
                
                for (int i = 0; i < folder.Children.Count; i++)
                {
                    Display(folder.Children[i], newPrefix, i == folder.Children.Count - 1);
                }
            }
        }
    }
}
