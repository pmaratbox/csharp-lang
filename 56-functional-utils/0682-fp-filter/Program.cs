// Filter even numbers from [1..6] using LINQ's Where (System.Linq, stdlib).
Console.WriteLine(string.Join(",", Enumerable.Range(1, 6).Where(x => x % 2 == 0)));
