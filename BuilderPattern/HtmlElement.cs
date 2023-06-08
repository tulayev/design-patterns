using System.Text;

namespace BuilderPattern
{
    public class HtmlElement
    {
        private const int indentSize = 2;

        public string Name { get; set; }

        public string Text { get; set; }

        public List<HtmlElement> Elements { get; set; } = new();

        public HtmlElement()
        {
        }

        public HtmlElement(string name, string text)
        {
            Name = name;
            Text = text;
        }

        private string HtmlElementToString(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', indentSize * indent);
            sb.AppendLine($"{i}<{Name}>");

            if (!string.IsNullOrWhiteSpace(Text)) 
            {
                sb.Append(new string(' ', indentSize * (indent + 1)));
                sb.AppendLine(Text);
            }

            foreach (var element in Elements)
                sb.Append(element.HtmlElementToString(indent + 1));

            sb.AppendLine($"{i}</{Name}>");
            return sb.ToString();
        }

        public override string ToString() =>
            HtmlElementToString(0);
    }
}
