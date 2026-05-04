namespace TemplateMethodPattern.Core
{
    internal abstract class DataExporter
    {
        // Template method — fixed sequence, can't be overridden
        public void Export(List<string> data)
        {
            FetchData(data);
            string formatted = FormatData(data);
            SaveToFile(formatted);
        }

        protected abstract string FormatData(List<string> data);

        private void FetchData(List<string> data)
        {
            Console.WriteLine($"[Exporter] Fetched {data.Count} records.");
        }

        private void SaveToFile(string content)
        {
            Console.WriteLine($"[Exporter] Saving...\r\n{content}");
            Console.WriteLine("[Exporter] Done.");
        }
    }
}
