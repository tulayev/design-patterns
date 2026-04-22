using FacadePattern.Helpers;

namespace FacadePattern
{
    public class MagicSquareGeneratorFacade
    {
        public List<List<int>> Generate(int size)
        {
            var generator = new Generator();
            var splitter = new Splitter();
            var verifier = new Verifier();

            return Generate(generator, splitter, verifier, size);
        }

        private static List<List<int>> Generate(Generator generator, Splitter splitter, Verifier verifier, int size)
        {
            var list = new List<List<int>>();

            while (list.Count < size)
            {
                list.Add(generator.Generate(size));
            }

            var splitted = splitter.Split(list);

            if (verifier.Verify(splitted))
            {
                return list;
            }

            return Generate(generator, splitter, verifier, size);
        }
    }
}
