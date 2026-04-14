namespace BuilderPattern
{
    public class HtmlBuilder
    {
        private readonly string _rootName;

        private HtmlElement _root = new();

        public HtmlBuilder(string rootName)
        {
            _rootName = rootName;
            _root.Name = _rootName;
        }

        public HtmlBuilder AddChild(string childName, string childText)
        {
            var element = new HtmlElement(childName, childText);
            _root.Elements.Add(element);

            return this;
        }

        public void Clear()
        {
            _root = new() { Name = _rootName };
        }

        public override string ToString()
        {
            return _root.ToString();
        }
    }
}
