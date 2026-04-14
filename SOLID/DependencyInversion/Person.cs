namespace SOLID.DependencyInversion
{
    internal enum RelationShip
    {
        Parent, Child
    }

    internal class Person
    {
        public string Name { get; set; }
    }

    internal interface IRelastionShipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }

    internal class RelationShips : IRelastionShipBrowser
    {
        private readonly List<(Person, RelationShip, Person)> _relations = new();

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
