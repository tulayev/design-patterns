using System.Text;

namespace BuilderPattern
{
    public class HtmlElement
    {
        public string Name { get; set; }

        public string Text { get; set; }

        private const int IndentSize = 2;

        public List<HtmlElement> Elements { get; set; } = new();

        public HtmlElement()
        {
        }

        public HtmlElement(string name, string text)
        {
            Name = name;
            Text = text;
        }

        public override string ToString()
        {
            return HtmlElementToString(0);
        }

        private string HtmlElementToString(int indent)
        {
            var sb = new StringBuilder();
            var tabSize = new string(' ', IndentSize * indent);

            sb.AppendLine($"{tabSize}<{Name}>");

            if (!string.IsNullOrWhiteSpace(Text)) 
            {
                sb.Append(new string(' ', IndentSize * (indent + 1)));
                sb.AppendLine(Text);
            }

            foreach (var element in Elements)
            {
                sb.Append(element.HtmlElementToString(indent + 1));
            }

            sb.AppendLine($"{tabSize}</{Name}>");

            return sb.ToString();
        }
    }
}
