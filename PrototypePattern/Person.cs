namespace PrototypePattern
{
    //[Serializable]
    public class Person 
    {
        public string[] Names { get; set; }

        public Address Address { get; set; }

        public Person()
        {   
        }

        public Person(string[] names, Address address)
        {
            Names = names;
            Address = address;
        }

        public override string ToString() =>
            $"{string.Join(", ", Names)} lives in {Address}";
    }

    //[Serializable]
    public class Address
    {
        public string City { get; set; }

        public string Street { get; set; }

        public Address()
        {
        }

        public Address(string city, string street)
        {
            City = city;
            Street = street;
        }

        public override string ToString() =>
            $"{Street}, {City}";
    }
}
