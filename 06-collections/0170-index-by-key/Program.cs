(int Id, string Name)[] people = [(1, "alice"), (2, "bob")];
var byId = people.ToDictionary(p => p.Id, p => p.Name);
Console.WriteLine($"id 2: {byId[2]}");
