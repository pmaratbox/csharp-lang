var people = new List<Person> { new("alice", 30), new("bob", 25) };
people.Sort();
Console.WriteLine(string.Join(" ", people.Select(p => p.Name)));

class Person(string name, int age) : IComparable<Person>
{
    public string Name => name;
    public int Age => age;
    public int CompareTo(Person? other) => Age.CompareTo(other!.Age);
}
