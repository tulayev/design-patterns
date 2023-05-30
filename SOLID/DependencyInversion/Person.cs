namespace SOLID.DependencyInversion
{
    public enum RelationShip
    {
        Parent, Child
    }

    public class Person
    {
        public string Name { get; set; }
    }

    public interface IRelastionShipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }

    public class RelationShips : IRelastionShipBrowser
    {
        private List<(Person, RelationShip, Person)> _relations = new();

        public void AddParentAndChild(Person parent, Person child)
        {
            _relations.Add((parent, RelationShip.Parent, child));
            _relations.Add((child, RelationShip.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return _relations.Where(x => x.Item1.Name == name && x.Item2 == RelationShip.Parent)
                .Select(x => x.Item3);  
        }
    }
}
