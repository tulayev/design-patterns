namespace SOLID.SingleResponsibility
{
    public class Journal
    {
        private readonly List<string> _entries = new List<string>();

        private static int _count = 0;

        public int AddEntry(string text)
        {
            _entries.Add($"{++_count}: {text}");
            return _count;
        }

        public void RemoveEntry(int index)
        {
            _entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _entries);
        }

        public void Save(string filename)
        {
            File.WriteAllText(filename, ToString());
        }
    }

    public class Persistence
    {
        public void SaveToFile(Journal journal, string fileName, bool ovewrite = false)
        {
            if (ovewrite || !File.Exists(fileName))
                File.WriteAllText(fileName, journal.ToString());
        }
    }
}
