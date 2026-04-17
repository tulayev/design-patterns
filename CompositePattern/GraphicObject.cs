using System.Text;

namespace CompositePattern
{
    internal class GraphicObject
    {
        public string Color { get; set; } = default!;
        public List<GraphicObject> Children => children.Value;
        public virtual string Name { get; set; } = "Group";

        private readonly Lazy<List<GraphicObject>> children = new();

        public override string ToString()
        {
            var sb = new StringBuilder();
            Print(sb, 0);
            return sb.ToString();
        }

        private void Print(StringBuilder sb, int depth)
        {
            sb.Append(new string('*', depth))
                .Append($"{Color} " ?? string.Empty)
                .AppendLine(Name);

            foreach (var child in Children)
            {
                child.Print(sb, depth + 1);
            }
        }
    }
}
