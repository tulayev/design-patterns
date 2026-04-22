namespace FacadePattern.Helpers
{
    internal class Verifier
    {
        public bool Verify(List<List<int>> array)
        {
            if (!array.Any())
            {
                return false;
            }

            var expected = array.First().Sum();

            return array.All(t => t.Sum() == expected);
        }
    }
}
