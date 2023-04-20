namespace SOLID.OpenClosed
{
    public enum Genre { SciFi, Comedy, Action, Fantasy, Horror }

    public class Movie
    {
        public string Title { get; set; }

        public Genre Genre { get; set; }

        public string Country { get; set; }

        public override string ToString() =>
            $"Movie: {Title}";
    }
}
