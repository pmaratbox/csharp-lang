var person = new Person
{
    Name = "Ada",
    Address = new Address { City = "London" },
};

Console.WriteLine(person.Address.City);

struct Address
{
    public string City;
}

struct Person
{
    public string Name;
    public Address Address;
}
