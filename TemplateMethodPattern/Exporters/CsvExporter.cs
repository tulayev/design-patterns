using TemplateMethodPattern.Core;

namespace TemplateMethodPattern.Exporters
{
    internal class CsvExporter : DataExporter
    {
        protected override string FormatData(List<string> data)
        {
            var csv = "id,name\r\n" + string.Join("\n", data.Select((item, i) => $"{i + 1},{item}"));
            return csv;
        }
    }
}
