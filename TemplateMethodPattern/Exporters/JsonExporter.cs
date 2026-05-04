using TemplateMethodPattern.Core;

namespace TemplateMethodPattern.Exporters
{
    internal class JsonExporter : DataExporter
    {
        protected override string FormatData(List<string> data)
        {
            var items = data.Select((item, i) => $"  {{ \"id\": {i + 1}, \"name\": \"{item}\" }}");
            return "[\r\n" + string.Join(",\r\n", items) + "\r\n]";
        }
    }
}
